using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WilmerVRH_DataPrep
{
    public class ExperimentList
    {
        public List<WilmerVRHData> experiments_list { get; set; }
    }

    public class WilmerVRHData// : IEquatable<WilmerVRVData>
    {
        public string sceneName { get; set; }
        public string sceneTitle { get; set; }
        public int presentationTime { get; set; }
        public int timeOut { get; set; }
        public double graspThreshold { get; set; }
        public int experimentMode { get; set; }
        public string controllerType { get; set; }
        public Option_dict serializedOptionsDictionary { get; set; }
    }
    public class Option_dict
    {
        public string[] key_strings { get; set; }
        public string[] value_strings { get; set; }
    }


    public class WilmerVRH_tests
    {
        public SortedDictionary<string, int[]> wilmerVRHTasks = new SortedDictionary<string, int[]>()
        {
            { "Throw_Soccer_Ball",new int[]{0, 0, 0 } },
            { "Sort_Blocks", new int[]{0, 0, 0 } },
            { "Pick_Up_Hairbrush", new int[]{0, 0, 0 } },
            { "Build_Tower_Different", new int[]{0, 0, 0 } },
            { "Build_Tower_Same", new int[]{0, 0, 0 } },
            { "Bake_Cookie", new int[]{0 } },
            { "Locate_Door_Handle", new int[]{0, 0, 0 } },
            { "Pick_Fruit", new int[]{0, 0, 0 } },
            { "Put_On_Glove", new int[]{0, 0, 0 } },
            { "High_Five", new int[]{0, 0, 0 } },
            { "Locate_Common_Items", new int[]{0, 0, 0 } },
            { "Touch_Light_Spot", new int[]{0, 0, 0 } },
            { "Locate_Light_Switch", new int[]{0, 0, 0 } },
            { "Cut_Meat", new int[]{0, 0, 0 } },
            { "Locate_Milk_Carton", new int[]{0, 0, 0 } },
            { "Touch_Moving_Light_Spot", new int[]{0, 0, 0 } },
            { "Cook_Pancake", new int[]{0 } },
            { "Sort_Pills", new int[]{0, 0, 0 } },
            { "Locate_Plate_Silverware", new int[]{0, 0 } },
            { "Whack_A_Mole", new int[]{0, 0, 0 } }

        };

        public static List<WilmerVRHData> ThrowSoccerBall(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();

            //difficulty level
            string diffLevel;
            switch (level)
            {
                case "easy":
                    diffLevel = "full-sized";
                    break;
                case "medium":
                    diffLevel = "4/6-sized";
                    break;
                case "hard":
                    diffLevel = "4/9-sized";
                    break;
                default:
                    diffLevel = "full-sized";
                    break;
            }

            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "scene06-throwing-paper",
                    sceneTitle = "Throw Soccer Ball",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new()
                {
                    new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectSize", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Left" }
                    },

                    new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectSize", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Right" }
                    },

                    new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectSize", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Random" }
                    }
                };
                return output;

            }

        }
        public static List<WilmerVRHData> SortBlocks(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();

            //difficulty level
            string diffLevel;
            switch (level)
            {
                case "easy":
                    diffLevel = "Black";
                    break;
                case "medium":
                    diffLevel = "Gray";
                    break;
                case "hard":
                    diffLevel = "Light Gray";
                    break;
                default:
                    diffLevel = "Black";
                    break;
            }

            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "scene03-sorting-blocks",
                    sceneTitle = "Sorting Blocks",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new()
                {
                    new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Left-Center-Right" }
                    },

                    new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Right-Center-Left" }
                    },

                    new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Right-Left-Center" }
                    },

                    new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Random" }
                    }
                };
                return output;

            }

        }
        public static List<WilmerVRHData> PickUpHairbrush(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();
            int numTest = 3;
            //difficulty level
            string diffLevel;
            switch (level)
            {
                case "easy":
                    diffLevel = "Black";
                    break;
                case "medium":
                    diffLevel = "Gray";
                    break;
                case "hard":
                    diffLevel = "Light Gray";
                    break;
                default:
                    diffLevel = "Black";
                    break;
            }

            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "scene08-locating-toothbrush",
                    sceneTitle = "Pickup Hairbrush",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new()
                {
                    new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Top Left" }
                    },

                    new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Top Right" }
                    },

                    new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Bottom Left" }
                    },

                     new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Bottom Right" }
                    }
                };

                //test
                for (int i = 0; i < numTest; i++)
                {
                    output.Add(new Option_dict
                    {
                        key_strings = new string[2] { "ObjectColor", "SpawnPosition" },
                        value_strings = new string[2] { diffLevel, "Random" }
                    });
                }

                return output;

            }

        }
        public static List<WilmerVRHData> BuildTowerDifferent(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();
            //int numTest = 1;
            //difficulty level
            string diffLevel;
            switch (level)
            {
                case "easy":
                    diffLevel = "Black";
                    break;
                case "medium":
                    diffLevel = "Gray";
                    break;
                case "hard":
                    diffLevel = "Light Gray";
                    break;
                default:
                    diffLevel = "Black";
                    break;
            }

            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "scene11-building-tower-diffrentSize",
                    sceneTitle = "Building Tower - Different Sizes",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new()
                {
                    new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Left-Center-Right" }
                    },

                    new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Random" }
                    }
                };

                return output;

            }

        }
        public static List<WilmerVRHData> BuildTowerSame(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();
            //int numTest = 1;
            //difficulty level
            string diffLevel;
            switch (level)
            {
                case "easy":
                    diffLevel = "Black";
                    break;
                case "medium":
                    diffLevel = "Gray";
                    break;
                case "hard":
                    diffLevel = "Light Gray";
                    break;
                default:
                    diffLevel = "Black";
                    break;
            }

            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "scene05-building-tower-sameSize",
                    sceneTitle = "Building Tower - Same Size",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new()
                {
                    new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Left-Center-Right" }
                    },

                    new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Random" }
                    }
                };

                return output;

            }

        }
        public static List<WilmerVRHData> BakeCookie(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();
            //int numTest = 1;
            //difficulty level
            string diffLevel;
            switch (level)
            {
                case "easy":
                    diffLevel = "Black";
                    break;
                default:
                    diffLevel = "Black";
                    break;
            }

            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "scene16-cookie-dough",
                    sceneTitle = "Baking Cookie",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new()
                {
                    new Option_dict
                    {
                        key_strings = new string[2]{ "BackgroundColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Generic" }
                    },

                    new Option_dict
                    {
                        key_strings = new string[2]{ "BackgroundColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Random" }
                    }
                };

                return output;

            }

        }
        public static List<WilmerVRHData> LocateDoorHandle(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();
            //int numTest = 1;
            //difficulty level
            string diffLevel;
            switch (level)
            {
                case "easy":
                    diffLevel = "Dark Brown";
                    break;
                case "medium":
                    diffLevel = "Light Brown";
                    break;
                case "hard":
                    diffLevel = "Light Gold";
                    break;
                default:
                    diffLevel = "Dark Brown";
                    break;
            }

            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "scene13-locate-door-handle",
                    sceneTitle = "Locating Door Handle",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new()
                {
                    new Option_dict
                    {
                        key_strings = new string[2]{ "BackgroundColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Left" }
                    },
                    new Option_dict
                    {
                        key_strings = new string[2]{ "BackgroundColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Right" }
                    }
                };

                for (int i = 0; i < 3; i++)
                {
                    output.Add(new Option_dict
                    {
                        key_strings = new string[2] { "BackgroundColor", "SpawnPosition" },
                        value_strings = new string[2] { diffLevel, "Random" }
                    });
                }

                return output;

            }

        }
        public static List<WilmerVRHData> PickFruit(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();
            //int numTest = 1;
            //difficulty level
            string diffLevel;
            switch (level)
            {
                case "easy":
                    diffLevel = "Black Grapes";
                    break;
                case "medium":
                    diffLevel = "Red Grapes";
                    break;
                case "hard":
                    diffLevel = "Green Grapes";
                    break;
                default:
                    diffLevel = "Black Grapes";
                    break;
            }

            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "scene10-locating-a-fruit",
                    sceneTitle = "Pick a Fruit",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new()
                {
                    new Option_dict
                    {
                        key_strings = new string[2]{ "PrefabLevel", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Left" }
                    },
                    new Option_dict
                    {
                        key_strings = new string[2]{ "PrefabLevel", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Center" }
                    },
                    new Option_dict
                    {
                        key_strings = new string[2]{ "PrefabLevel", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Right" }
                    }
                };

                for (int i = 0; i < 3; i++)
                {
                    output.Add(new Option_dict
                    {
                        key_strings = new string[2] { "PrefabLevel", "SpawnPosition" },
                        value_strings = new string[2] { diffLevel, "Random" }
                    });
                }

                return output;

            }

        }
        public static List<WilmerVRHData> PutOnGlove(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();
            //int numTest = 1;
            //difficulty level
            string diffLevel;
            switch (level)
            {
                case "easy":
                    diffLevel = "Black";
                    break;
                case "medium":
                    diffLevel = "Gray";
                    break;
                case "hard":
                    diffLevel = "Light Gray";
                    break;
                default:
                    diffLevel = "Black";
                    break;
            }

            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "scene18-putting-on-glove",
                    sceneTitle = "Putting on Gloves",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new()
                {
                    new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Left straight forward" }
                    },
                    new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Left 90 degree" }
                    },
                    new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Right straight forward" }
                    },
                     new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Right 90 degree" }
                    }
                };

                for (int i = 0; i < 3; i++)
                {
                    output.Add(new Option_dict
                    {
                        key_strings = new string[2] { "ObjectColor", "SpawnPosition" },
                        value_strings = new string[2] { diffLevel, "Random" }
                    });
                }

                return output;

            }

        }
        public static List<WilmerVRHData> HighFive(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();
            //int numTest = 1;
            //difficulty level
            string diffLevel;
            switch (level)
            {
                case "easy":
                    diffLevel = "African";
                    break;
                case "medium":
                    diffLevel = "North Indian";
                    break;
                case "hard":
                    diffLevel = "North European";
                    break;
                default:
                    diffLevel = "African";
                    break;
            }

            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "scene19-highfive",
                    sceneTitle = "Highfive",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new()
                {
                    new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectColor", "ClutterContent" },
                        value_strings = new string[2]{ diffLevel, "Right High" }
                    },
                    new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectColor", "ClutterContent" },
                        value_strings = new string[2]{ diffLevel, "Left High" }
                    },
                    new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectColor", "ClutterContent" },
                        value_strings = new string[2]{ diffLevel, "Left Lower" }
                    }
                };

                for (int i = 0; i < 3; i++)
                {
                    output.Add(new Option_dict
                    {
                        key_strings = new string[2] { "ObjectColor", "ClutterContent" },
                        value_strings = new string[2] { diffLevel, "Random" }
                    });
                }

                return output;

            }

        }
        public static List<WilmerVRHData> LocateCommonItems(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();
            //int numTest = 1;
            //difficulty level
            string diffLevel;
            string[] commonItems;
            switch (level)
            {
                case "easy":
                    diffLevel = "1 clutter object";
                    commonItems = new string[4] { "Wallet", "Phone", "Scissors", "Notebook" };
                    break;
                case "medium":
                    diffLevel = "2 clutter objects";
                    commonItems = new string[5] { "Wallet", "Phone", "Scissors", "Notebook", "Sunglasses" };
                    break;
                case "hard":
                    diffLevel = "4 clutter objects";
                    commonItems = new string[7] { "Wallet", "Phone", "Scissors", "Notebook", "Sunglasses", "Tape dispenser", "Calculator" };
                    break;
                default:
                    diffLevel = "1 clutter object";
                    commonItems = new string[4] { "Wallet", "Phone", "Scissors", "Notebook" };
                    break;
            }

            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "scene14-locate-wallet-keys-phone",
                    sceneTitle = "Locating Common Items",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new();
                foreach (string clutterContent in commonItems)
                {
                    output.Add(
                         new Option_dict
                         {
                             key_strings = new string[2] { "ClutterLevel", "ClutterContent" },
                             value_strings = new string[2] { diffLevel, clutterContent }
                         }
                        );
                }

                output.Add(
                    new Option_dict
                    {
                        key_strings = new string[2] { "ClutterLevel", "ClutterContent" },
                        value_strings = new string[2] { diffLevel, "Random" }
                    }
                    );

                return output;

            }

        }
        public static List<WilmerVRHData> TouchLightSpot(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();
            //int numTest = 1;
            //difficulty level
            string diffLevel;
            string[] position = new string[4] { "Top Left", "Top Right", "Bottom Left", "Bottom Right" };
            switch (level)
            {
                case "easy":
                    diffLevel = "Dark";
                    break;
                case "medium":
                    diffLevel = "Dim";
                    break;
                case "hard":
                    diffLevel = "Normal";
                    break;
                default:
                    diffLevel = "Dark";
                    break;
            }

            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "scene01-touch-light-spot",
                    sceneTitle = "Touch the Light Spot",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new();
                foreach (string spawnPosition in position)
                {
                    output.Add(
                         new Option_dict
                         {
                             key_strings = new string[2] { "LightIntensity", "SpawnPosition" },
                             value_strings = new string[2] { diffLevel, spawnPosition }
                         }
                        );
                }
                for (int i = 0; i < 3; i++)
                {
                    output.Add(
                    new Option_dict
                    {
                        key_strings = new string[2] { "LightIntensity", "SpawnPosition" },
                        value_strings = new string[2] { diffLevel, "Random" }
                    }
                    );
                }


                return output;

            }

        }
        public static List<WilmerVRHData> LocateLightSwitch(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();
            //int numTest = 1;
            //difficulty level
            string diffLevel;
            string[] position = new string[4] { "Top Left", "Top Right", "Bottom Left", "Bottom Right" };
            switch (level)
            {
                case "easy":
                    diffLevel = "White";
                    break;
                case "medium":
                    diffLevel = "Gray";
                    break;
                case "hard":
                    diffLevel = "Dark Gray";
                    break;
                default:
                    diffLevel = "White";
                    break;
            }

            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "scene07-locating-light-switch",
                    sceneTitle = "Locate Light Switch",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new();
                foreach (string spawnPosition in position)
                {
                    output.Add(
                         new Option_dict
                         {
                             key_strings = new string[2] { "ObjectColor", "SpawnPosition" },
                             value_strings = new string[2] { diffLevel, spawnPosition }
                         }
                        );
                }
                for (int i = 0; i < 3; i++)
                {
                    output.Add(
                    new Option_dict
                    {
                        key_strings = new string[2] { "ObjectColor", "SpawnPosition" },
                        value_strings = new string[2] { diffLevel, "Random" }
                    }
                    );
                }


                return output;

            }

        }
        public static List<WilmerVRHData> CutMeat(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();
            //int numTest = 1;
            //difficulty level
            string diffLevel;
            string[] position = new string[4] { "Front Left", "Front Right", "Rear Left", "Rear Right" };
            switch (level)
            {
                case "easy":
                    diffLevel = "Steak";
                    break;
                case "medium":
                    diffLevel = "Pork Chop";
                    break;
                case "hard":
                    diffLevel = "Fish";
                    break;
                default:
                    diffLevel = "Steak";
                    break;
            }

            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "scene20-cutting-steak",
                    sceneTitle = "Cutting Meat",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new();
                foreach (string spawnPosition in position)
                {
                    output.Add(
                         new Option_dict
                         {
                             key_strings = new string[2] { "PrefabLevel", "SpawnPosition" },
                             value_strings = new string[2] { diffLevel, spawnPosition }
                         }
                        );
                }
                for (int i = 0; i < 3; i++)
                {
                    output.Add(
                    new Option_dict
                    {
                        key_strings = new string[2] { "PrefabLevel", "SpawnPosition" },
                        value_strings = new string[2] { diffLevel, "Random" }
                    }
                    );
                }


                return output;

            }

        }
        public static List<WilmerVRHData> LocateMilkCarton(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();
            //int numTest = 1;
            //difficulty level
            string diffLevel;
            string[] objects;
            switch (level)
            {
                case "easy":
                    diffLevel = "1 clutter object";
                    objects = new string[2] { "Milk Carton", "Bread Loaf" };
                    break;
                case "medium":
                    diffLevel = "2 clutter objects";
                    objects = new string[3] { "Milk Carton", "Bread Loaf", "Can" };
                    break;
                case "hard":
                    diffLevel = "4 clutter objects";
                    objects = new string[5] { "Milk Carton", "Bread Loaf", "Can", "Meat", "Cheese" };
                    break;
                default:
                    diffLevel = "1 clutter object";
                    objects = new string[2] { "Milk Carton", "Bread Loaf" };
                    break;
            }

            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "scene09-locating-milk-carton",
                    sceneTitle = "Locate Milk Carton",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new();
                foreach (string clutterContent in objects)
                {
                    output.Add(
                         new Option_dict
                         {
                             key_strings = new string[2] { "ClutterLevel", "ClutterContent" },
                             value_strings = new string[2] { diffLevel, clutterContent }
                         }
                        );
                }
                for (int i = 0; i < 3; i++)
                {
                    output.Add(
                    new Option_dict
                    {
                        key_strings = new string[2] { "ClutterLevel", "ClutterContent" },
                        value_strings = new string[2] { diffLevel, "Random" }
                    }
                    );
                }


                return output;

            }

        }
        public static List<WilmerVRHData> TouchMovingLightSpot(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();
            //int numTest = 1;
            //difficulty level
            string diffLevel;
            string[] position = new string[4] { "LeftToRight", "RightToLeft", "BottomToTop", "TopToBottom" };
            switch (level)
            {
                case "easy":
                    diffLevel = "Dark";
                    break;
                case "medium":
                    diffLevel = "Dim";
                    break;
                case "hard":
                    diffLevel = "Normal";
                    break;
                default:
                    diffLevel = "Dark";
                    break;
            }

            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "scene12-touch-moving-circle",
                    sceneTitle = "Touch the Moving Spot",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new();
                foreach (string spawnPosition in position)
                {
                    output.Add(
                         new Option_dict
                         {
                             key_strings = new string[2] { "LightIntensity", "SpawnPosition" },
                             value_strings = new string[2] { diffLevel, spawnPosition }
                         }
                        );
                }
                for (int i = 0; i < 3; i++)
                {
                    output.Add(
                    new Option_dict
                    {
                        key_strings = new string[2] { "LightIntensity", "SpawnPosition" },
                        value_strings = new string[2] { diffLevel, "Random" }
                    }
                    );
                }


                return output;

            }

        }
        public static List<WilmerVRHData> CookPancake(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();
            //int numTest = 1;
            //difficulty level
            string diffLevel;
            switch (level)
            {
                case "easy":
                    diffLevel = "White";
                    break;
                default:
                    diffLevel = "White";
                    break;
            }

            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "scene17-making-pancake",
                    sceneTitle = "Cooking Pancake",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new()
                {
                    new Option_dict
                    {
                        key_strings = new string[2]{ "BackgroundColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Generic" }
                    },

                    new Option_dict
                    {
                        key_strings = new string[2]{ "BackgroundColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Random" }
                    }
                };

                return output;

            }

        }
        public static List<WilmerVRHData> SortPills(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();

            //difficulty level
            string diffLevel;
            switch (level)
            {
                case "easy":
                    diffLevel = "Black";
                    break;
                case "medium":
                    diffLevel = "Gray";
                    break;
                case "hard":
                    diffLevel = "Light Gray";
                    break;
                default:
                    diffLevel = "Black";
                    break;
            }

            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "scene04-sorting-pills",
                    sceneTitle = "Sorting Pills",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new()
                {
                    new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Left-Center-Right" }
                    },

                    new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Right-Center-Left" }
                    },

                    new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Right-Left-Center" }
                    },

                    new Option_dict
                    {
                        key_strings = new string[2]{ "ObjectColor", "SpawnPosition" },
                        value_strings = new string[2]{ diffLevel, "Random" }
                    }
                };
                return output;

            }

        }
        public static List<WilmerVRHData> LocatePlateSilverware(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();
            //int numTest = 1;
            //difficulty level
            string diffLevel;
            string[] objects = new string[5] { "Fork", "Knife", "Napkin", "Plate", "Cup" };
            switch (level)
            {
                case "easy":
                    diffLevel = "Black";
                    break;
                case "medium":
                    diffLevel = "Gray";
                    break;
                default:
                    diffLevel = "Black";
                    break;
            }

            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "scene15-locate-plates-silverware-napkins",
                    sceneTitle = "Locating Plates Silverware",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new();
                foreach (string clutterContent in objects)
                {
                    output.Add(
                         new Option_dict
                         {
                             key_strings = new string[2] { "BackgroundColor", "ClutterContent" },
                             value_strings = new string[2] { diffLevel, clutterContent }
                         }
                         );
                }

                output.Add(
                    new Option_dict
                    {
                        key_strings = new string[2] { "BackgroundColor", "ClutterContent" },
                        value_strings = new string[2] { diffLevel, "Random" }
                    }
                    );

                return output;

            }

        }
        public static List<WilmerVRHData> WhackAMole(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();
            //int numTest = 1;
            //difficulty level
            string diffLevel;
            string[] position = new string[1] { "Row 1 Column 1/Row 2 Column 3" };
            switch (level)
            {
                case "easy":
                    diffLevel = "4 Seconds";
                    break;
                case "medium":
                    diffLevel = "2 Seconds";
                    break;
                case "hard":
                    diffLevel = "1 Second";
                    break;
                default:
                    diffLevel = "4 Seconds";
                    break;
            }

            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "scene02-whackamole",
                    sceneTitle = "Whack-a-mole",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new();
                foreach (string spawnPosition in position)
                {
                    output.Add(
                         new Option_dict
                         {
                             key_strings = new string[2] { "TimeLimit", "SpawnPosition" },
                             value_strings = new string[2] { diffLevel, spawnPosition }
                         }
                        );
                }
                for (int i = 0; i < 3; i++)
                {
                    output.Add(
                    new Option_dict
                    {
                        key_strings = new string[2] { "TimeLimit", "SpawnPosition" },
                        value_strings = new string[2] { diffLevel, "Random" }
                    }
                    );
                }


                return output;

            }

        }

    }
    public class WilmerVRH_Practice
    {
        public SortedDictionary<string, int> wilmerVRHPracticeTasks = new SortedDictionary<string, int>()
        {
            { "Practice_Blocks", 0 },
            { "Practice_Ball", 0 },
            { "Practice_Plate_and_Fork", 0 },
            { "Practice_Toothbrush", 0 },
            { "Practice_Pouring_Batter", 0 },
            { "Practice_Pancake", 0 },
        };
        public static List<WilmerVRHData> PracticeBlocks(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();
            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "practice01-block",
                    sceneTitle = "Practice 1 - Building Blocks",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new() {
                 new Option_dict
                 {
                     key_strings = new string[2] { "NoneDifficulty", "NoneCondition" },
                     value_strings = new string[2] { "practice01-block", "" }
                 }
                };
                return output;

            }

        }
        public static List<WilmerVRHData> PracticeBall(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();
            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "practice02-ball",
                    sceneTitle = "Practice 2 - Soccer Ball",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new() {
                 new Option_dict
                 {
                     key_strings = new string[2] { "NoneDifficulty", "NoneCondition" },
                     value_strings = new string[2] { "practice02-ball", "" }
                 }
                };
                return output;

            }

        }
        public static List<WilmerVRHData> PracticePlateandFork(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();
            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "practice03-utensil",
                    sceneTitle = "Practice 3 - Fork on Plate",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new() {
                 new Option_dict
                 {
                     key_strings = new string[2] { "NoneDifficulty", "NoneCondition" },
                     value_strings = new string[2] { "practice03-utensil", "" }
                 }
                };
                return output;

            }

        }
        public static List<WilmerVRHData> PracticeToothbrush(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();
            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "practice04-toothbrush",
                    sceneTitle = "Practice 4 - Brush in Cup",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new() {
                 new Option_dict
                 {
                     key_strings = new string[2] { "NoneDifficulty", "NoneCondition" },
                     value_strings = new string[2] { "practice04-toothbrush", "" }
                 }
                };
                return output;

            }

        }
        public static List<WilmerVRHData> PracticePouringBatter(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();
            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "practice05-pouring",
                    sceneTitle = "Practice 5 - Pouring Batter",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new() {
                 new Option_dict
                 {
                     key_strings = new string[2] { "NoneDifficulty", "NoneCondition" },
                     value_strings = new string[2] { "practice05-pouring", "" }
                 }
                };
                return output;

            }

        }
        public static List<WilmerVRHData> PracticePancake(string level = "easy", int time = 1)
        {
            List<WilmerVRHData> data = new();
            List<Option_dict> task_option_dict = Create_option_dict();
            foreach (Option_dict item in task_option_dict)
            {
                data.Add(
                new WilmerVRHData()
                {
                    sceneName = "practice06-scooping",
                    sceneTitle = "Practice 6 - Scooping Pancake",
                    presentationTime = time,
                    timeOut = 600,
                    graspThreshold = 0.3499999940395355,
                    experimentMode = 0,
                    controllerType = "Hands",
                    serializedOptionsDictionary = item
                }
                );
            }

            return data;

            List<Option_dict> Create_option_dict()
            {
                List<Option_dict> output = new() {
                 new Option_dict
                 {
                     key_strings = new string[2] { "NoneDifficulty", "NoneCondition" },
                     value_strings = new string[2] { "practice06-scooping", "" }
                 }
                };
                return output;

            }

        }



    }

}
