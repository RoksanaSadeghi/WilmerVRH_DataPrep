﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using Ookii.Dialogs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace WilmerVRH_DataPrep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool selectAll_ = true;
        bool easyAll = true;
        bool mediumAll = true;
        bool hardAll = true;

        WilmerVRH_tests vrh = new WilmerVRH_tests();
        public static List<List<WilmerVRHData>> selectedTasks = new();

        public static int time;
        public static int numberOfPlaylists;

        public MainWindow()
        {
            InitializeComponent();
            AddTasks(vrh.wilmerVRHTasks);
        }

        private void AddTasks(SortedDictionary<string, int[]> taskNameList)
        {
            Style s = (Style)FindResource("lB");

            foreach (string taskName in taskNameList.Keys)
            {
                ListBox newListBox = new ListBox() { Style = s };

                newListBox.Name = taskName;
                newListBox.Width = 500;

                AddTaskComponents(newListBox, taskName, taskNameList[taskName].Count());
                TaskListBox.Items.Add(newListBox);
            }
        }
        private void AddTaskComponents(ListBox VRTask, string taskName, int numLevels)
        {
            Label taskNameLabel = new Label();
            taskNameLabel.Width = 130;
            taskNameLabel.Height = 24;
            taskNameLabel.Content = VRTask.Name.Replace("_", " ");
            taskNameLabel.FontSize = 11;
            VRTask.Items.Add(taskNameLabel);

            string[] difficultyLevel = new string[] { "__0", "__1", "__2" }; //easy, medium, hard

            CheckBox cb;
            for (int i = 0; i < numLevels; i++)
            {
                cb = new CheckBox();
                cb.Foreground = Brushes.Black;
                cb.Height = 24;
                cb.Width = 60;
                cb.Name = "CheckBox__" + taskName + difficultyLevel[i];

                cb.Checked += CheckBoxDifficultyLevel_Checked;
                cb.Unchecked += CheckBoxDifficultyLevel_Unchecked;

                VRTask.Items.Add(cb);
            }

        }

        private void CheckBoxDifficultyLevel_Checked(object sender, RoutedEventArgs e)
        {

            CheckBox cb = sender as CheckBox;
            string[] name = cb.Name.ToString().Split("__");
            int i = Convert.ToInt32(name[2]);

            vrh.wilmerVRHTasks[name[1]][i] = 1;
        }

        private void CheckBoxDifficultyLevel_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            string[] name = cb.Name.ToString().Split("__");
            int i = Convert.ToInt32(name[2]);

            vrh.wilmerVRHTasks[name[1]][i] = 0;
        }

        private void CreatePlaylist_Click(object sender, RoutedEventArgs e)
        {

            object obj = new WilmerVRH_tests();
            Type type = obj.GetType();

            time = new();
            numberOfPlaylists = new();

            if ( !int.TryParse(NumberOfPlaylistsTextBox.Text, out numberOfPlaylists) || !int.TryParse(TimeTextBox.Text, out time))
            {
                MessageBox.Show("Please correct the input.");
                return;
            }

            //add the selected tests to the list
            selectedTasks = new();
            foreach (var item in vrh.wilmerVRHTasks)
            {
                bool cont = true;
                for (int i = 0; i < item.Value.Length; i++)
                {
                    if (item.Value[i] == 1) { cont = false;break; }
                }
                if (cont) { continue; }
                string methodName = item.Key.Replace("_", "");

                List<WilmerVRHData> t = new List<WilmerVRHData>();
                string[] diffLevel = new string[] { "easy", "medium", "hard" };
                for (int i = 0;i<item.Value.Length;i++)
                {
                    if (item.Value[i] == 1)
                    {
                        MethodInfo method = type.GetMethod(methodName);
                        t.AddRange(method.Invoke(obj, new object[] { diffLevel[i], time }) as List<WilmerVRHData>);
                    }
                }
                
                selectedTasks.Add(t);
            }

            //PracticeScenes;
            PracticeScenes practiceScenesWindow = new PracticeScenes();
            practiceScenesWindow.Show();
           

        }

        private void TestNameLabel_Click(object sender, RoutedEventArgs e)
        {
            if (selectAll_)
            {
                foreach (ListBox lb in TaskListBox.Items)
                {
                    for (int i = 1; i < lb.Items.Count; i++)
                    {
                        CheckBox tmp = (CheckBox)lb.Items[i];
                        tmp.IsChecked = true;
                    }
                }
                selectAll_ = false;
            }
            else
            {
                foreach (ListBox lb in TaskListBox.Items)
                {
                    for (int i = 1; i < lb.Items.Count; i++)
                    {
                        CheckBox tmp = (CheckBox)lb.Items[i];
                        tmp.IsChecked = false;
                    }
                }
                selectAll_ = true;
            }

        }

        private void EasyLabel_Click(object sender, RoutedEventArgs e)
        {
            if (easyAll)
            {
                foreach (ListBox lb in TaskListBox.Items)
                {
                    CheckBox tmp = (CheckBox)lb.Items[1];
                    tmp.IsChecked = true;
                }
                easyAll = false;
            }
            else
            {
                foreach (ListBox lb in TaskListBox.Items)
                {
                    CheckBox tmp = (CheckBox)lb.Items[1];
                    tmp.IsChecked = false;
                }
                easyAll = true;
            }
        }

        private void MediumLabel_Click(object sender, RoutedEventArgs e)
        {
            if (mediumAll)
            {
                foreach (ListBox lb in TaskListBox.Items)
                {
                    if(lb.Items.Count < 3) { continue; }
                    CheckBox tmp = (CheckBox)lb.Items[2];
                    tmp.IsChecked = true;
                }
                mediumAll = false;
            }
            else
            {
                foreach (ListBox lb in TaskListBox.Items)
                {
                    if (lb.Items.Count < 3) { continue; }
                    CheckBox tmp = (CheckBox)lb.Items[2];
                    tmp.IsChecked = false;
                }
                mediumAll = true;
            }
        }

        private void HardLabel_Click(object sender, RoutedEventArgs e)
        {
            if (hardAll)
            {
                foreach (ListBox lb in TaskListBox.Items)
                {
                    if (lb.Items.Count < 4) { continue; }
                    CheckBox tmp = (CheckBox)lb.Items[3];
                    tmp.IsChecked = true;
                }
                hardAll = false;
            }
            else
            {
                foreach (ListBox lb in TaskListBox.Items)
                {
                    if (lb.Items.Count < 4) { continue; }
                    CheckBox tmp = (CheckBox)lb.Items[3];
                    tmp.IsChecked = false;
                }
                hardAll = true;
            }
        }
    }
}
