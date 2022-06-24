using System;
using System.Collections.Generic;
using System.Linq;

namespace MatchmakingSystem
{
    internal class FakeDataMaker
    {
        readonly Random _random = new Random();

        private List<string> _habitList = new List<string>()
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

        private readonly List<string> _firstName = new List<string>()
        {
            "陳", "林", "黃", "張", "李", "王", "吳", "劉", "蔡", "楊",
            "許", "鄭", "謝", "洪", "郭", "邱", "曾", "廖", "賴", "徐",
            "周", "葉", "蘇", "莊", "呂", "江", "何", "蕭", "羅", "高",
            "潘", "簡", "朱", "鍾", "游", "彭", "詹", "胡", "施", "沈",
            "余", "盧", "梁", "趙", "顏", "柯", "翁", "魏", "孫", "戴",
        };

        private List<string> _maleName = new List<string>()
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

        private List<string> _femaleName = new List<string>()
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

        public List<Individual> FakeData(int count)
        {
            List<Individual> fakeData = new List<Individual>();
            {
                fakeData.Add(GenerateIndividual());
            }

            return fakeData;
        }

        Individual GenerateIndividual()
        {
            string gender = RandomGender();

            Individual individual = new Individual(
                RandomName(gender), 
                gender, 
                _random.Next(18, 60),
                RandomHabits());
            return individual;
        }

        private string RandomHabits()
        {
            string combineString = "";

            _habitList = _habitList.OrderBy(x => _random.Next()).ToList();
            for (int i = 0; i < _random.Next(1, 5); i++)
            {
                combineString += _habitList[i] + ",";
            }

            return combineString;
        }

        string RandomGender()
        {
            return _random.Next(0, 2) == 0 ? "MALE" : "FEMALE";
        }

        public string RandomName(string gender)
        {
            string first = _firstName[_random.Next(0, _firstName.Count)];
            string lastName = gender == "MALE"
                ? _maleName[_random.Next(_maleName.Count)]
                : _femaleName[_random.Next(_femaleName.Count)];
            return first + lastName;
        }
    }
}