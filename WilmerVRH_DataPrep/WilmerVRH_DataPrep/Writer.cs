using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace WilmerVRH_DataPrep
{
    class Writer
    {
        static Random rand_ = new Random();

        public static void CreateMultipleJasons(string outputDir)
        {
            try
            {
                List<WilmerVRHData> testp = MergeLists();
                if (testp.Count == 0) 
                {
                    string errorMessageTxt = "Please select a task!";
                    string captionError = "Failed";
                    MessageBoxButton buttonOK = MessageBoxButton.OK;
                    MessageBoxImage iconError = MessageBoxImage.Error;
                    MessageBoxResult error_;

                    error_ = MessageBox.Show(errorMessageTxt, captionError, buttonOK, iconError, MessageBoxResult.Yes);

                    return; 
                }
                for (int i = 0; i < MainWindow.numberOfPlaylists; i++)
                {
                    string outputFile = Path.Combine(outputDir, (i + 1).ToString().PadLeft(3, '0'));
                    List<WilmerVRHData> p = MergeLists();
                    CreateAJason(p, outputFile);
                }

                //create the default one for the demo
                string defaultFile = Path.Combine(outputDir, "default");
                List<WilmerVRHData> default_p = DefaultJason();
                CreateAJason(default_p, defaultFile);

                string messageBoxText = "Finished: Output file(s) are created in the requested directory.\n" + outputDir;
                string caption = "Successful";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.None;
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);

            }
            catch (Exception ex) { MessageBox.Show("ERROR: The output didn't created.\n" + ex.ToString()); }
        }

        private static void CreateAJason(List<WilmerVRHData> playlist, string outputFile)
        {
            ExperimentList experimentList_ = new ExperimentList { experiments_list = playlist };
            string json = JsonSerializer.Serialize(experimentList_);
            json = json.Replace("\\u0027", "'");
            File.WriteAllText(outputFile + ".json", json);

        }
        private static List<List<WilmerVRHData>> RandomizeOrder()
        {
            return MainWindow.selectedTasks.OrderBy(_ => rand_.Next()).ToList();
        }

        private static List<WilmerVRHData> MergeLists()
        {
            List<WilmerVRHData> mergedList = new List<WilmerVRHData>();
            
            List<List<WilmerVRHData>> practice = PracticeScenes.selectedPracticeTasks;
            List<List<WilmerVRHData>> playlist = RandomizeOrder();
            foreach(var item in practice)
            {
                mergedList.AddRange(item);
            }
            foreach (var item in playlist)
            {
                mergedList.AddRange(item);
            }
            return mergedList;
        }

        private static List<WilmerVRHData> DefaultJason()
        {
            List<WilmerVRHData> mergedList = new List<WilmerVRHData>();
            
            mergedList.AddRange(WilmerVRH_Practice.PracticeBlocks());
            mergedList.AddRange(WilmerVRH_Practice.PracticeBall());
            mergedList.AddRange(WilmerVRH_Practice.PracticePlateandFork());
            mergedList.AddRange(WilmerVRH_Practice.PracticeToothbrush());
            mergedList.AddRange(WilmerVRH_Practice.PracticePouringBatter());
            mergedList.AddRange(WilmerVRH_Practice.PracticePancake());

            mergedList.AddRange(WilmerVRH_tests.ThrowSoccerBall("easy"));
            mergedList.AddRange(WilmerVRH_tests.ThrowSoccerBall("medium"));
            mergedList.AddRange(WilmerVRH_tests.ThrowSoccerBall("hard"));
            mergedList.AddRange(WilmerVRH_tests.SortBlocks("easy"));
            mergedList.AddRange(WilmerVRH_tests.SortBlocks("medium"));
            mergedList.AddRange(WilmerVRH_tests.SortBlocks("hard"));
            mergedList.AddRange(WilmerVRH_tests.PickUpHairbrush("easy"));
            mergedList.AddRange(WilmerVRH_tests.PickUpHairbrush("medium"));
            mergedList.AddRange(WilmerVRH_tests.PickUpHairbrush("hard"));
            mergedList.AddRange(WilmerVRH_tests.BuildTowerDifferent("easy"));
            mergedList.AddRange(WilmerVRH_tests.BuildTowerDifferent("medium"));
            mergedList.AddRange(WilmerVRH_tests.BuildTowerDifferent("hard"));
            mergedList.AddRange(WilmerVRH_tests.BuildTowerSame("easy"));
            mergedList.AddRange(WilmerVRH_tests.BuildTowerSame("medium"));
            mergedList.AddRange(WilmerVRH_tests.BuildTowerSame("hard"));
            mergedList.AddRange(WilmerVRH_tests.BakeCookie());
            mergedList.AddRange(WilmerVRH_tests.LocateDoorHandle("easy"));
            mergedList.AddRange(WilmerVRH_tests.LocateDoorHandle("medium"));
            mergedList.AddRange(WilmerVRH_tests.LocateDoorHandle("hard"));
            mergedList.AddRange(WilmerVRH_tests.PickFruit("easy"));
            mergedList.AddRange(WilmerVRH_tests.PickFruit("medium"));
            mergedList.AddRange(WilmerVRH_tests.PickFruit("hard"));
            mergedList.AddRange(WilmerVRH_tests.PutOnGlove("easy"));
            mergedList.AddRange(WilmerVRH_tests.PutOnGlove("medium"));
            mergedList.AddRange(WilmerVRH_tests.PutOnGlove("hard"));
            mergedList.AddRange(WilmerVRH_tests.HighFive("easy"));
            mergedList.AddRange(WilmerVRH_tests.HighFive("medium"));
            mergedList.AddRange(WilmerVRH_tests.HighFive("hard"));
            mergedList.AddRange(WilmerVRH_tests.LocateCommonItems("easy"));
            mergedList.AddRange(WilmerVRH_tests.LocateCommonItems("medium"));
            mergedList.AddRange(WilmerVRH_tests.LocateCommonItems("hard"));
            mergedList.AddRange(WilmerVRH_tests.TouchLightSpot("easy"));
            mergedList.AddRange(WilmerVRH_tests.TouchLightSpot("medium"));
            mergedList.AddRange(WilmerVRH_tests.TouchLightSpot("hard"));
            mergedList.AddRange(WilmerVRH_tests.LocateLightSwitch("easy"));
            mergedList.AddRange(WilmerVRH_tests.LocateLightSwitch("medium"));
            mergedList.AddRange(WilmerVRH_tests.LocateLightSwitch("hard"));
            mergedList.AddRange(WilmerVRH_tests.CutMeat("easy"));
            mergedList.AddRange(WilmerVRH_tests.CutMeat("medium"));
            mergedList.AddRange(WilmerVRH_tests.CutMeat("hard"));
            mergedList.AddRange(WilmerVRH_tests.LocateMilkCarton("easy"));
            mergedList.AddRange(WilmerVRH_tests.LocateMilkCarton("medium"));
            mergedList.AddRange(WilmerVRH_tests.LocateMilkCarton("hard"));
            mergedList.AddRange(WilmerVRH_tests.TouchMovingLightSpot("easy"));
            mergedList.AddRange(WilmerVRH_tests.TouchMovingLightSpot("medium"));
            mergedList.AddRange(WilmerVRH_tests.TouchMovingLightSpot("hard"));
            mergedList.AddRange(WilmerVRH_tests.CookPancake());
            mergedList.AddRange(WilmerVRH_tests.SortPills("easy"));
            mergedList.AddRange(WilmerVRH_tests.SortPills("medium"));
            mergedList.AddRange(WilmerVRH_tests.SortPills("hard"));
            mergedList.AddRange(WilmerVRH_tests.LocatePlateSilverware("easy"));
            mergedList.AddRange(WilmerVRH_tests.LocatePlateSilverware("medium"));
            mergedList.AddRange(WilmerVRH_tests.WhackAMole("easy"));
            mergedList.AddRange(WilmerVRH_tests.WhackAMole("medium"));
            mergedList.AddRange(WilmerVRH_tests.WhackAMole("hard"));

            return mergedList;
        }



    }
}
