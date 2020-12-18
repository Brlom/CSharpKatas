﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.BE
{
    public class MorseCode
    {
        public string MorseDecode(string morseCode, bool toMorse)
        {
            string newMsg = String.Empty;

            if (!toMorse && !string.IsNullOrEmpty(morseCode))
            {
                var morseList = morseCode.Split(" ");
                foreach(string morse in morseList)
                { 
                    newMsg += findDecodedValue(morse);
                }
            }
            else if (toMorse && !string.IsNullOrEmpty(morseCode))
            {
                var morseStr = morseCode.ToUpper();
                foreach (char morse in morseStr)
                {
                    newMsg += $"{findMorseValue(morse)} ";
                }
            }
            else
            {
                return String.Empty;
            }

            return toMorse ? newMsg.TrimEnd(' ') : $"{newMsg.Substring(0, 1)}{newMsg.Substring(1).ToLower()}";
        }

        public string findDecodedValue(string morseCode)
        {
            var morseDict = new Dictionary<string, string>
            {
                { ".-", "A" },
                { "-...", "B" },
                { "-.-.", "C" },
                { "-..", "D" },
                { ".", "E" },
                { "..-.", "F" },
                { "--.", "G" },
                { "....", "H" },
                { "..", "I" },
                { ".---", "J" },
                { "-.-", "K" },
                { ".-..", "L" },
                { "--", "M" },
                { "-.", "N" },
                { "---", "O" },
                { ".--.", "P" },
                { "--.-", "Q" },
                { ".-.", "R" },
                { "...", "S" },
                { "-", "T" },
                { "..-", "U" },
                { "...-", "V" },
                { ".--", "W" },
                { "-..-", "X" },
                { "-.--", "Y" },
                { "--..", "Z" },
                { "-----", "0" },
                { ".----", "1" },
                { "..---", "2" },
                { "...--", "3" },
                { "....-", "4" },
                { ".....", "5" },
                { "-....", "6" },
                { "--...", "7" },
                { "---..", "8" },
                { "----.", "9" }
            };

            return morseDict[morseCode];
        }

        public string findMorseValue(char morseCode)
        {
            var toMorseDict = new Dictionary<char, string>
            {
                { 'A', ".-" },
                { 'B', "-..." },
                { 'C', "-.-." },
                { 'D', "-.." },
                { 'E', "."},
                { 'F', "..-." },
                { 'G', "--." },
                { 'H', "...." },
                { 'I', ".." },
                { 'J', ".---" },
                { 'K', "-.-" },
                { 'L', ".-.." },
                { 'M', "--" },
                { 'N', "-." },
                { 'O', "---" },
                { 'P', ".--." },
                { 'Q', "--.-" },
                { 'R', ".-." },
                { 'S', "..." },
                { 'T', "-" },
                { 'U', "..-" },
                { 'V', "...-" },
                { 'W', ".--" },
                { 'X', "-..-" },
                { 'Y', "-.--" },
                { 'Z', "--.." },
                { '0', "-----" },
                { '1', ".----" },
                { '2', "..---" },
                { '3', "...--" },
                { '4', "....-" },
                { '5', "....." },
                { '6', "-...." },
                { '7', "--..." },
                { '8', "---.." },
                { '9', "----." }
            };

            return toMorseDict[morseCode];
        }
    }
}