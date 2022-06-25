using System;
using System.Collections.Generic;
using System.Linq;

namespace MatchmakingSystem
{
    internal class FakeDataMaker
    {
        #region Property

        static readonly Random Random = new Random();

        private static  List<string> _habitList = new List<string>()
        {
            "籃球",
            "羽球",
            "畫畫",
            "騎腳踏車",
            "保齡球",
            "網球",
            "爬山",
            "看書",
            "健行",
            "游泳",
            "彈吉他",
            "棒球",
            "溜冰",
            "溜滑板",
        };

        private static readonly List<string> FirstNames = new List<string>()
        {
            "陳", "林", "黃", "張", "李", "王", "吳", "劉", "蔡", "楊",
            "許", "鄭", "謝", "洪", "郭", "邱", "曾", "廖", "賴", "徐",
            "周", "葉", "蘇", "莊", "呂", "江", "何", "蕭", "羅", "高",
            "潘", "簡", "朱", "鍾", "游", "彭", "詹", "胡", "施", "沈",
            "余", "盧", "梁", "趙", "顏", "柯", "翁", "魏", "孫", "戴",
        };

        private static readonly List<string> MaleNames = new List<string>()
        {
            "承翰",
            "冠廷",
            "承恩",
            "冠宇",
            "彥廷",
            "宇翔",
            "柏翰",
            "昱翔",
            "宗翰",
            "柏諺",
            "宇軒",
            "柏宇",
            "家豪",
            "冠霖",
            "柏均",
            "俊佑",
            "凱翔",
            "柏霖",
            "柏鈞",
            "哲維",
            "承祐",
            "承諺",
            "宥翔",
            "柏睿",
            "子軒",
            "育誠",
            "柏翔",
            "彥均",
            "庭瑋",
            "宇宸",
            "承佑",
            "奕辰",
            "柏凱",
            "品蓁",
            "子翔",
            "冠宏",
            "哲瑋",
            "宥均",
            "柏廷",
            "宇辰",
            "子傑",
            "昱安",
            "冠霆",
            "宇哲",
            "博鈞",
            "品睿",
            "奕翔",
            "靖淳",
            "俊諺",
            "宥廷",
            "家瑋",
            "俊傑",
            "子豪",
            "柏丞",
            "宥霖",
            "宥任",
            "宥丞",
            "祐誠",
            "冠佑",
            "宥嘉",
            "承勳",
            "昱廷",
            "俊宇",
            "智凱",
            "家銘",
            "昱凱",
            "奕安",
            "威廷",
            "彥霖",
            "俊凱",
            "凱傑",
            "柏安",
            "柏勳",
            "哲宇",
            "秉宏",
            "柏宏",
            "柏毅",
            "秉叡",
            "柏辰",
            "瑋庭",
            "秉軒",
            "俊廷",
            "秉諺",
            "俞安",
            "彥辰",
            "宸瑋",
            "政諺",
            "子庭",
            "廷宇",
            "浩宇",
            "家維",
            "凱文",
            "奕廷",
            "景翔",
            "聖翔",
            "宥鈞",
            "祐嘉",
            "彥丞",
            "子維",
            "佑丞",
        };

        private static readonly List<string> FemaleNames = new List<string>()
        {
            "思妤",
            "宜蓁",
            "詩涵",
            "欣妤",
            "宜臻",
            "宜庭",
            "佳穎",
            "雅婷",
            "雅筑",
            "宥辰",
            "怡萱",
            "詠晴",
            "子涵",
            "怡婷",
            "家瑜",
            "郁婷",
            "佳妤",
            "子晴",
            "宥蓁",
            "姿妤",
            "品妤",
            "鈺婷",
            "雅涵",
            "佳欣",
            "亭妤",
            "詩婷",
            "心妤",
            "思婷",
            "庭瑜",
            "芊妤",
            "子恩",
            "怡君",
            "翊瑄",
            "思涵",
            "佩珊",
            "品萱",
            "子芸",
            "舒涵",
            "庭瑄",
            "佳蓉",
            "宇恩",
            "羽彤",
            "冠妤",
            "育瑄",
            "雅雯",
            "佳恩",
            "佳臻",
            "昀臻",
            "郁晴",
            "怡蓁",
            "苡瑄",
            "于萱",
            "芸瑄",
            "冠穎",
            "怡安",
            "欣怡",
            "芷瑄",
            "禹彤",
            "庭妤",
            "家妤",
            "雅琪",
            "芷妍",
            "佳蓁",
            "宜萱",
            "宜芳",
            "子瑄",
            "靖雯",
            "芷萱",
            "郁涵",
            "宜君",
            "怡瑄",
            "沛璇",
            "芯瑜",
            "心瑜",
            "芳瑜",
            "芷涵",
            "佳怡",
            "品妍",
            "宣妤",
            "姿穎",
            "怡臻",
            "芷瑜",
            "依璇",
            "詩晴",
            "昱辰",
            "湘婷",
            "羽涵",
            "丞恩",
            "育萱",
            "佳儀",
            "庭萱",
            "珮慈",
            "子萱",
            "雅晴",
            "子瑜",
            "怡靜",
            "語婕",
            "睿恩",
            "妍蓁",
            "欣穎",
        };

        #endregion

        public static List<Individual> GetFakeData(int count)
        {
            List<Individual> fakeData = new List<Individual>();

            for (int i = 0; i < count; i++)
            {
                fakeData.Add(GenerateIndividual());
            }

            //如果不需要看到，可以關閉
            PrintData(fakeData);

            return fakeData;
        }

        static Individual GenerateIndividual()
        {
            string gender = RandomGender();

            Individual individual = new Individual(
                RandomName(gender),
                gender,
                RandomAge(18, 60),
                RandomHabits(1, 5),
                RandomCoord(0, 500));
            return individual;
        }

        #region Random Method

        private static int RandomAge(int minValue, int maxValue)
        {
            return Random.Next(minValue, maxValue);
        }

        private static string RandomHabits(int minValue, int maxValue)
        {
            string combineHabits = "";

            _habitList = _habitList.OrderBy(x => Random.Next()).ToList();
            int randomCount = Random.Next(minValue, maxValue);
            for (int i = 0; i < randomCount; i++)
            {
                combineHabits += _habitList[i];
                if (i < randomCount - 1)
                {
                    combineHabits += ",";
                }
            }

            return combineHabits;
        }

        private static string RandomGender()
        {
            return Random.Next(0, 2) == 0 ? "MALE" : "FEMALE";
        }

        private static string RandomName(string gender)
        {
            string first = FirstNames[Random.Next(0, FirstNames.Count)];
            string lastName = gender == "MALE"
                ? MaleNames[Random.Next(MaleNames.Count)]
                : FemaleNames[Random.Next(FemaleNames.Count)];
            return first + lastName;
        }

        static Coord RandomCoord(int minValue, int maxValue)
        {
            return new Coord(Random.Next(minValue, maxValue), Random.Next(minValue, maxValue));
        }

        #endregion

        #region Debug

        private static void PrintData(List<Individual> fakeData)
        {
            Console.WriteLine("============= Print Fake Data =============");
            foreach (var individual in fakeData)
            {
                individual.PrintInfo();
            }

            Console.WriteLine("\n=============================\n");
        }

        #endregion
    }
}