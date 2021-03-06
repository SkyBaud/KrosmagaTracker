﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonCardsParser
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CardType { get; set; }
        public int CostAP { get; set; }
        public int Life { get; set; }
        public int Attack { get; set; }
        public int MovementPoint { get; set; }
        public int[] Families { get; set; }
        public bool IsToken { get; set; }
        public int Rarity { get; set; }
        public int GodType { get; set; }
        public int Extension { get; set; }
        public int InfiniteFamily { get; set; }
        public int[] LinkedCards { get; set; }
        public Texts Texts { get; set; }

        public string UIName { get; set; }

        public Card() { }

        public void SetUIName(string lang)
        {
            switch(lang)
            {
                case "BR":
                    UIName = Texts.NameBR;
                    break;
                case "RU":
                    UIName = Texts.NameRU;
                    break;
                case "FR":
                    UIName = Texts.NameFR;
                    break;
                case "EN":
                    UIName = Texts.NameEN;
                    break;
                case "ES":
                    UIName = Texts.NameES;
                    break;
                default:
                    UIName = Texts.NameFR;
                    break;
            }
    }
    }
}
