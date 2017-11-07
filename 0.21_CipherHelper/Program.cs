using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._21_CipherHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            string apostrophe = "'";
            char replacerVar = apostrophe[0];

            //Creates cipher 1
            Dictionary<char, char> cipher01 = new Dictionary<char, char>();
            cipher01.Add('a', 'z');
            cipher01.Add('b', 'a');
            cipher01.Add('c', 'b');
            cipher01.Add('d', 'c');
            cipher01.Add('e', 'd');
            cipher01.Add('f', 'e');
            cipher01.Add('g', 'f');
            cipher01.Add('h', 'g');
            cipher01.Add('i', 'h');
            cipher01.Add('j', 'i');
            cipher01.Add('k', 'j');
            cipher01.Add('l', 'k');
            cipher01.Add('m', 'l');
            cipher01.Add('n', 'm');
            cipher01.Add('o', 'n');
            cipher01.Add('p', 'o');
            cipher01.Add('q', 'p');
            cipher01.Add('r', 'q');
            cipher01.Add('s', 'r');
            cipher01.Add('t', 's');
            cipher01.Add('u', 't');
            cipher01.Add('v', 'u');
            cipher01.Add('w', 'v');
            cipher01.Add('x', 'w');
            cipher01.Add('y', 'x');
            cipher01.Add('z', 'y');

            //Creates cipher 2
            Dictionary<char, char> cipher02 = new Dictionary<char, char>();
            cipher02.Add('a', 'y');
            cipher02.Add('b', 'z');
            cipher02.Add('c', 'a');
            cipher02.Add('d', 'b');
            cipher02.Add('e', 'c');
            cipher02.Add('f', 'd');
            cipher02.Add('g', 'e');
            cipher02.Add('h', 'f');
            cipher02.Add('i', 'g');
            cipher02.Add('j', 'h');
            cipher02.Add('k', 'i');
            cipher02.Add('l', 'j');
            cipher02.Add('m', 'k');
            cipher02.Add('n', 'l');
            cipher02.Add('o', 'm');
            cipher02.Add('p', 'n');
            cipher02.Add('q', 'o');
            cipher02.Add('r', 'p');
            cipher02.Add('s', 'q');
            cipher02.Add('t', 'r');
            cipher02.Add('u', 's');
            cipher02.Add('v', 't');
            cipher02.Add('w', 'u');
            cipher02.Add('x', 'v');
            cipher02.Add('y', 'w');
            cipher02.Add('z', 'x');

            //Creates cipher 3
            Dictionary<char, char> cipher03 = new Dictionary<char, char>();
            cipher03.Add('a', 'x');
            cipher03.Add('b', 'y');
            cipher03.Add('c', 'z');
            cipher03.Add('d', 'a');
            cipher03.Add('e', 'b');
            cipher03.Add('f', 'c');
            cipher03.Add('g', 'd');
            cipher03.Add('h', 'e');
            cipher03.Add('i', 'f');
            cipher03.Add('j', 'g');
            cipher03.Add('k', 'h');
            cipher03.Add('l', 'i');
            cipher03.Add('m', 'j');
            cipher03.Add('n', 'k');
            cipher03.Add('o', 'l');
            cipher03.Add('p', 'm');
            cipher03.Add('q', 'n');
            cipher03.Add('r', 'o');
            cipher03.Add('s', 'p');
            cipher03.Add('t', 'q');
            cipher03.Add('u', 'r');
            cipher03.Add('v', 's');
            cipher03.Add('w', 't');
            cipher03.Add('x', 'u');
            cipher03.Add('y', 'v');
            cipher03.Add('z', 'w');

            //Creates cipher 4
            Dictionary<char, char> cipher04 = new Dictionary<char, char>();
            cipher04.Add('a', 'w');
            cipher04.Add('b', 'x');
            cipher04.Add('c', 'y');
            cipher04.Add('d', 'z');
            cipher04.Add('e', 'a');
            cipher04.Add('f', 'b');
            cipher04.Add('g', 'c');
            cipher04.Add('h', 'd');
            cipher04.Add('i', 'e');
            cipher04.Add('j', 'f');
            cipher04.Add('k', 'g');
            cipher04.Add('l', 'h');
            cipher04.Add('m', 'i');
            cipher04.Add('n', 'j');
            cipher04.Add('o', 'k');
            cipher04.Add('p', 'l');
            cipher04.Add('q', 'm');
            cipher04.Add('r', 'n');
            cipher04.Add('s', 'o');
            cipher04.Add('t', 'p');
            cipher04.Add('u', 'q');
            cipher04.Add('v', 'r');
            cipher04.Add('w', 's');
            cipher04.Add('x', 't');
            cipher04.Add('y', 'u');
            cipher04.Add('z', 'v');

            //Creates cipher 5
            Dictionary<char, char> cipher05 = new Dictionary<char, char>();
            cipher05.Add('a', 'v');
            cipher05.Add('b', 'w');
            cipher05.Add('c', 'x');
            cipher05.Add('d', 'y');
            cipher05.Add('e', 'z');
            cipher05.Add('f', 'a');
            cipher05.Add('g', 'b');
            cipher05.Add('h', 'c');
            cipher05.Add('i', 'd');
            cipher05.Add('j', 'e');
            cipher05.Add('k', 'f');
            cipher05.Add('l', 'g');
            cipher05.Add('m', 'h');
            cipher05.Add('n', 'i');
            cipher05.Add('o', 'j');
            cipher05.Add('p', 'k');
            cipher05.Add('q', 'l');
            cipher05.Add('r', 'm');
            cipher05.Add('s', 'n');
            cipher05.Add('t', 'o');
            cipher05.Add('u', 'p');
            cipher05.Add('v', 'q');
            cipher05.Add('w', 'r');
            cipher05.Add('x', 's');
            cipher05.Add('y', 't');
            cipher05.Add('z', 'u');

            //Creates cipher 6
            Dictionary<char, char> cipher06 = new Dictionary<char, char>();
            cipher06.Add('a', 'u');
            cipher06.Add('b', 'v');
            cipher06.Add('c', 'w');
            cipher06.Add('d', 'x');
            cipher06.Add('e', 'y');
            cipher06.Add('f', 'z');
            cipher06.Add('g', 'a');
            cipher06.Add('h', 'b');
            cipher06.Add('i', 'c');
            cipher06.Add('j', 'd');
            cipher06.Add('k', 'e');
            cipher06.Add('l', 'f');
            cipher06.Add('m', 'g');
            cipher06.Add('n', 'h');
            cipher06.Add('o', 'i');
            cipher06.Add('p', 'j');
            cipher06.Add('q', 'k');
            cipher06.Add('r', 'l');
            cipher06.Add('s', 'm');
            cipher06.Add('t', 'n');
            cipher06.Add('u', 'o');
            cipher06.Add('v', 'p');
            cipher06.Add('w', 'q');
            cipher06.Add('x', 'r');
            cipher06.Add('y', 's');
            cipher06.Add('z', 't');

            //Creates cipher 7
            Dictionary<char, char> cipher07 = new Dictionary<char, char>();
            cipher07.Add('a', 't');
            cipher07.Add('b', 'u');
            cipher07.Add('c', 'v');
            cipher07.Add('d', 'w');
            cipher07.Add('e', 'x');
            cipher07.Add('f', 'y');
            cipher07.Add('g', 'z');
            cipher07.Add('h', 'a');
            cipher07.Add('i', 'b');
            cipher07.Add('j', 'c');
            cipher07.Add('k', 'd');
            cipher07.Add('l', 'e');
            cipher07.Add('m', 'f');
            cipher07.Add('n', 'g');
            cipher07.Add('o', 'h');
            cipher07.Add('p', 'i');
            cipher07.Add('q', 'j');
            cipher07.Add('r', 'k');
            cipher07.Add('s', 'l');
            cipher07.Add('t', 'm');
            cipher07.Add('u', 'n');
            cipher07.Add('v', 'o');
            cipher07.Add('w', 'p');
            cipher07.Add('x', 'q');
            cipher07.Add('y', 'r');
            cipher07.Add('z', 's');

            //Creates cipher 8
            Dictionary<char, char> cipher08 = new Dictionary<char, char>();
            cipher08.Add('a', 's');
            cipher08.Add('b', 't');
            cipher08.Add('c', 'u');
            cipher08.Add('d', 'v');
            cipher08.Add('e', 'w');
            cipher08.Add('f', 'x');
            cipher08.Add('g', 'y');
            cipher08.Add('h', 'z');
            cipher08.Add('i', 'a');
            cipher08.Add('j', 'b');
            cipher08.Add('k', 'c');
            cipher08.Add('l', 'd');
            cipher08.Add('m', 'e');
            cipher08.Add('n', 'f');
            cipher08.Add('o', 'g');
            cipher08.Add('p', 'h');
            cipher08.Add('q', 'i');
            cipher08.Add('r', 'j');
            cipher08.Add('s', 'k');
            cipher08.Add('t', 'l');
            cipher08.Add('u', 'm');
            cipher08.Add('v', 'n');
            cipher08.Add('w', 'o');
            cipher08.Add('x', 'p');
            cipher08.Add('y', 'q');
            cipher08.Add('z', 'r');

            //Creates cipher 9
            Dictionary<char, char> cipher09 = new Dictionary<char, char>();
            cipher09.Add('a', 'r');
            cipher09.Add('b', 's');
            cipher09.Add('c', 't');
            cipher09.Add('d', 'u');
            cipher09.Add('e', 'v');
            cipher09.Add('f', 'w');
            cipher09.Add('g', 'x');
            cipher09.Add('h', 'y');
            cipher09.Add('i', 'z');
            cipher09.Add('j', 'a');
            cipher09.Add('k', 'b');
            cipher09.Add('l', 'c');
            cipher09.Add('m', 'd');
            cipher09.Add('n', 'e');
            cipher09.Add('o', 'f');
            cipher09.Add('p', 'g');
            cipher09.Add('q', 'h');
            cipher09.Add('r', 'i');
            cipher09.Add('s', 'j');
            cipher09.Add('t', 'k');
            cipher09.Add('u', 'l');
            cipher09.Add('v', 'm');
            cipher09.Add('w', 'n');
            cipher09.Add('x', 'o');
            cipher09.Add('y', 'p');
            cipher09.Add('z', 'q');

            //Creates cipher 10
            Dictionary<char, char> cipher10 = new Dictionary<char, char>();
            cipher10.Add('a', 'q');
            cipher10.Add('b', 'r');
            cipher10.Add('c', 's');
            cipher10.Add('d', 't');
            cipher10.Add('e', 'u');
            cipher10.Add('f', 'v');
            cipher10.Add('g', 'w');
            cipher10.Add('h', 'x');
            cipher10.Add('i', 'y');
            cipher10.Add('j', 'z');
            cipher10.Add('k', 'a');
            cipher10.Add('l', 'b');
            cipher10.Add('m', 'c');
            cipher10.Add('n', 'd');
            cipher10.Add('o', 'e');
            cipher10.Add('p', 'f');
            cipher10.Add('q', 'g');
            cipher10.Add('r', 'h');
            cipher10.Add('s', 'i');
            cipher10.Add('t', 'j');
            cipher10.Add('u', 'k');
            cipher10.Add('v', 'l');
            cipher10.Add('w', 'm');
            cipher10.Add('x', 'n');
            cipher10.Add('y', 'o');
            cipher10.Add('z', 'p');

            //Creates cipher 11
            Dictionary<char, char> cipher11 = new Dictionary<char, char>();
            cipher11.Add('a', 'p');
            cipher11.Add('b', 'q');
            cipher11.Add('c', 'r');
            cipher11.Add('d', 's');
            cipher11.Add('e', 't');
            cipher11.Add('f', 'u');
            cipher11.Add('g', 'v');
            cipher11.Add('h', 'w');
            cipher11.Add('i', 'x');
            cipher11.Add('j', 'y');
            cipher11.Add('k', 'z');
            cipher11.Add('l', 'a');
            cipher11.Add('m', 'b');
            cipher11.Add('n', 'c');
            cipher11.Add('o', 'd');
            cipher11.Add('p', 'e');
            cipher11.Add('q', 'f');
            cipher11.Add('r', 'g');
            cipher11.Add('s', 'h');
            cipher11.Add('t', 'i');
            cipher11.Add('u', 'j');
            cipher11.Add('v', 'k');
            cipher11.Add('w', 'l');
            cipher11.Add('x', 'm');
            cipher11.Add('y', 'n');
            cipher11.Add('z', 'o');

            //Creates cipher 12
            Dictionary<char, char> cipher12 = new Dictionary<char, char>();
            cipher12.Add('a', 'o');
            cipher12.Add('b', 'p');
            cipher12.Add('c', 'q');
            cipher12.Add('d', 'r');
            cipher12.Add('e', 's');
            cipher12.Add('f', 't');
            cipher12.Add('g', 'u');
            cipher12.Add('h', 'v');
            cipher12.Add('i', 'w');
            cipher12.Add('j', 'x');
            cipher12.Add('k', 'y');
            cipher12.Add('l', 'z');
            cipher12.Add('m', 'a');
            cipher12.Add('n', 'b');
            cipher12.Add('o', 'c');
            cipher12.Add('p', 'd');
            cipher12.Add('q', 'e');
            cipher12.Add('r', 'f');
            cipher12.Add('s', 'g');
            cipher12.Add('t', 'h');
            cipher12.Add('u', 'i');
            cipher12.Add('v', 'j');
            cipher12.Add('w', 'k');
            cipher12.Add('x', 'l');
            cipher12.Add('y', 'm');
            cipher12.Add('z', 'n');

            //Creates cipher 13
            Dictionary<char, char> cipher13 = new Dictionary<char, char>();
            cipher13.Add('a', 'n');
            cipher13.Add('b', 'o');
            cipher13.Add('c', 'p');
            cipher13.Add('d', 'q');
            cipher13.Add('e', 'r');
            cipher13.Add('f', 's');
            cipher13.Add('g', 't');
            cipher13.Add('h', 'u');
            cipher13.Add('i', 'v');
            cipher13.Add('j', 'w');
            cipher13.Add('k', 'x');
            cipher13.Add('l', 'y');
            cipher13.Add('m', 'z');
            cipher13.Add('n', 'a');
            cipher13.Add('o', 'b');
            cipher13.Add('p', 'c');
            cipher13.Add('q', 'd');
            cipher13.Add('r', 'e');
            cipher13.Add('s', 'f');
            cipher13.Add('t', 'g');
            cipher13.Add('u', 'h');
            cipher13.Add('v', 'i');
            cipher13.Add('w', 'j');
            cipher13.Add('x', 'k');
            cipher13.Add('y', 'l');
            cipher13.Add('z', 'm');

            //Creates cipher 14
            Dictionary<char, char> cipher14 = new Dictionary<char, char>();
            cipher14.Add('a', 'm');
            cipher14.Add('b', 'n');
            cipher14.Add('c', 'o');
            cipher14.Add('d', 'p');
            cipher14.Add('e', 'q');
            cipher14.Add('f', 'r');
            cipher14.Add('g', 's');
            cipher14.Add('h', 't');
            cipher14.Add('i', 'u');
            cipher14.Add('j', 'v');
            cipher14.Add('k', 'w');
            cipher14.Add('l', 'x');
            cipher14.Add('m', 'y');
            cipher14.Add('n', 'z');
            cipher14.Add('o', 'a');
            cipher14.Add('p', 'b');
            cipher14.Add('q', 'c');
            cipher14.Add('r', 'd');
            cipher14.Add('s', 'e');
            cipher14.Add('t', 'f');
            cipher14.Add('u', 'g');
            cipher14.Add('v', 'h');
            cipher14.Add('w', 'i');
            cipher14.Add('x', 'j');
            cipher14.Add('y', 'k');
            cipher14.Add('z', 'l');

            //Creates cipher 15
            Dictionary<char, char> cipher15 = new Dictionary<char, char>();
            cipher15.Add('a', 'l');
            cipher15.Add('b', 'm');
            cipher15.Add('c', 'n');
            cipher15.Add('d', 'o');
            cipher15.Add('e', 'p');
            cipher15.Add('f', 'q');
            cipher15.Add('g', 'r');
            cipher15.Add('h', 's');
            cipher15.Add('i', 't');
            cipher15.Add('j', 'u');
            cipher15.Add('k', 'v');
            cipher15.Add('l', 'w');
            cipher15.Add('m', 'x');
            cipher15.Add('n', 'y');
            cipher15.Add('o', 'z');
            cipher15.Add('p', 'a');
            cipher15.Add('q', 'b');
            cipher15.Add('r', 'c');
            cipher15.Add('s', 'd');
            cipher15.Add('t', 'e');
            cipher15.Add('u', 'f');
            cipher15.Add('v', 'g');
            cipher15.Add('w', 'h');
            cipher15.Add('x', 'i');
            cipher15.Add('y', 'j');
            cipher15.Add('z', 'k');

            //Creates cipher 16
            Dictionary<char, char> cipher16 = new Dictionary<char, char>();
            cipher16.Add('a', 'k');
            cipher16.Add('b', 'l');
            cipher16.Add('c', 'm');
            cipher16.Add('d', 'n');
            cipher16.Add('e', 'o');
            cipher16.Add('f', 'p');
            cipher16.Add('g', 'q');
            cipher16.Add('h', 'r');
            cipher16.Add('i', 's');
            cipher16.Add('j', 't');
            cipher16.Add('k', 'u');
            cipher16.Add('l', 'v');
            cipher16.Add('m', 'w');
            cipher16.Add('n', 'x');
            cipher16.Add('o', 'y');
            cipher16.Add('p', 'z');
            cipher16.Add('q', 'a');
            cipher16.Add('r', 'b');
            cipher16.Add('s', 'c');
            cipher16.Add('t', 'd');
            cipher16.Add('u', 'e');
            cipher16.Add('v', 'f');
            cipher16.Add('w', 'g');
            cipher16.Add('x', 'h');
            cipher16.Add('y', 'i');
            cipher16.Add('z', 'j');

            //Creates cipher 17
            Dictionary<char, char> cipher17 = new Dictionary<char, char>();
            cipher17.Add('a', 'j');
            cipher17.Add('b', 'k');
            cipher17.Add('c', 'l');
            cipher17.Add('d', 'm');
            cipher17.Add('e', 'n');
            cipher17.Add('f', 'o');
            cipher17.Add('g', 'p');
            cipher17.Add('h', 'q');
            cipher17.Add('i', 'r');
            cipher17.Add('j', 's');
            cipher17.Add('k', 't');
            cipher17.Add('l', 'u');
            cipher17.Add('m', 'v');
            cipher17.Add('n', 'w');
            cipher17.Add('o', 'x');
            cipher17.Add('p', 'y');
            cipher17.Add('q', 'z');
            cipher17.Add('r', 'a');
            cipher17.Add('s', 'b');
            cipher17.Add('t', 'c');
            cipher17.Add('u', 'd');
            cipher17.Add('v', 'e');
            cipher17.Add('w', 'f');
            cipher17.Add('x', 'g');
            cipher17.Add('y', 'h');
            cipher17.Add('z', 'i');

            //Creates cipher 18
            Dictionary<char, char> cipher18 = new Dictionary<char, char>();
            cipher18.Add('a', 'i');
            cipher18.Add('b', 'j');
            cipher18.Add('c', 'k');
            cipher18.Add('d', 'l');
            cipher18.Add('e', 'm');
            cipher18.Add('f', 'n');
            cipher18.Add('g', 'o');
            cipher18.Add('h', 'p');
            cipher18.Add('i', 'q');
            cipher18.Add('j', 'r');
            cipher18.Add('k', 's');
            cipher18.Add('l', 't');
            cipher18.Add('m', 'u');
            cipher18.Add('n', 'v');
            cipher18.Add('o', 'w');
            cipher18.Add('p', 'x');
            cipher18.Add('q', 'y');
            cipher18.Add('r', 'z');
            cipher18.Add('s', 'a');
            cipher18.Add('t', 'b');
            cipher18.Add('u', 'c');
            cipher18.Add('v', 'd');
            cipher18.Add('w', 'e');
            cipher18.Add('x', 'f');
            cipher18.Add('y', 'g');
            cipher18.Add('z', 'h');

            //Creates cipher 19
            Dictionary<char, char> cipher19 = new Dictionary<char, char>();
            cipher19.Add('a', 'h');
            cipher19.Add('b', 'i');
            cipher19.Add('c', 'j');
            cipher19.Add('d', 'k');
            cipher19.Add('e', 'l');
            cipher19.Add('f', 'm');
            cipher19.Add('g', 'n');
            cipher19.Add('h', 'o');
            cipher19.Add('i', 'p');
            cipher19.Add('j', 'q');
            cipher19.Add('k', 'r');
            cipher19.Add('l', 's');
            cipher19.Add('m', 't');
            cipher19.Add('n', 'u');
            cipher19.Add('o', 'v');
            cipher19.Add('p', 'w');
            cipher19.Add('q', 'x');
            cipher19.Add('r', 'y');
            cipher19.Add('s', 'z');
            cipher19.Add('t', 'a');
            cipher19.Add('u', 'b');
            cipher19.Add('v', 'c');
            cipher19.Add('w', 'd');
            cipher19.Add('x', 'e');
            cipher19.Add('y', 'f');
            cipher19.Add('z', 'g');

            //Creates cipher 20
            Dictionary<char, char> cipher20 = new Dictionary<char, char>();
            cipher20.Add('a', 'g');
            cipher20.Add('b', 'h');
            cipher20.Add('c', 'i');
            cipher20.Add('d', 'j');
            cipher20.Add('e', 'k');
            cipher20.Add('f', 'l');
            cipher20.Add('g', 'm');
            cipher20.Add('h', 'n');
            cipher20.Add('i', 'o');
            cipher20.Add('j', 'p');
            cipher20.Add('k', 'q');
            cipher20.Add('l', 'r');
            cipher20.Add('m', 's');
            cipher20.Add('n', 't');
            cipher20.Add('o', 'u');
            cipher20.Add('p', 'v');
            cipher20.Add('q', 'w');
            cipher20.Add('r', 'x');
            cipher20.Add('s', 'y');
            cipher20.Add('t', 'z');
            cipher20.Add('u', 'a');
            cipher20.Add('v', 'b');
            cipher20.Add('w', 'c');
            cipher20.Add('x', 'd');
            cipher20.Add('y', 'e');
            cipher20.Add('z', 'f');

            //Creates cipher 21
            Dictionary<char, char> cipher21 = new Dictionary<char, char>();
            cipher21.Add('a', 'f');
            cipher21.Add('b', 'g');
            cipher21.Add('c', 'h');
            cipher21.Add('d', 'i');
            cipher21.Add('e', 'j');
            cipher21.Add('f', 'k');
            cipher21.Add('g', 'l');
            cipher21.Add('h', 'm');
            cipher21.Add('i', 'n');
            cipher21.Add('j', 'o');
            cipher21.Add('k', 'p');
            cipher21.Add('l', 'q');
            cipher21.Add('m', 'r');
            cipher21.Add('n', 's');
            cipher21.Add('o', 't');
            cipher21.Add('p', 'u');
            cipher21.Add('q', 'v');
            cipher21.Add('r', 'w');
            cipher21.Add('s', 'x');
            cipher21.Add('t', 'y');
            cipher21.Add('u', 'z');
            cipher21.Add('v', 'a');
            cipher21.Add('w', 'b');
            cipher21.Add('x', 'c');
            cipher21.Add('y', 'd');
            cipher21.Add('z', 'e');

            //Creates cipher 22
            Dictionary<char, char> cipher22 = new Dictionary<char, char>();
            cipher22.Add('a', 'e');
            cipher22.Add('b', 'f');
            cipher22.Add('c', 'g');
            cipher22.Add('d', 'h');
            cipher22.Add('e', 'i');
            cipher22.Add('f', 'j');
            cipher22.Add('g', 'k');
            cipher22.Add('h', 'l');
            cipher22.Add('i', 'm');
            cipher22.Add('j', 'n');
            cipher22.Add('k', 'o');
            cipher22.Add('l', 'p');
            cipher22.Add('m', 'q');
            cipher22.Add('n', 'r');
            cipher22.Add('o', 's');
            cipher22.Add('p', 't');
            cipher22.Add('q', 'u');
            cipher22.Add('r', 'v');
            cipher22.Add('s', 'w');
            cipher22.Add('t', 'x');
            cipher22.Add('u', 'y');
            cipher22.Add('v', 'z');
            cipher22.Add('w', 'a');
            cipher22.Add('x', 'b');
            cipher22.Add('y', 'c');
            cipher22.Add('z', 'd');

            //Creates cipher 23
            Dictionary<char, char> cipher23 = new Dictionary<char, char>();
            cipher23.Add('a', 'd');
            cipher23.Add('b', 'e');
            cipher23.Add('c', 'f');
            cipher23.Add('d', 'g');
            cipher23.Add('e', 'h');
            cipher23.Add('f', 'i');
            cipher23.Add('g', 'j');
            cipher23.Add('h', 'k');
            cipher23.Add('i', 'l');
            cipher23.Add('j', 'm');
            cipher23.Add('k', 'n');
            cipher23.Add('l', 'o');
            cipher23.Add('m', 'p');
            cipher23.Add('n', 'q');
            cipher23.Add('o', 'r');
            cipher23.Add('p', 's');
            cipher23.Add('q', 't');
            cipher23.Add('r', 'u');
            cipher23.Add('s', 'v');
            cipher23.Add('t', 'w');
            cipher23.Add('u', 'x');
            cipher23.Add('v', 'y');
            cipher23.Add('w', 'z');
            cipher23.Add('x', 'a');
            cipher23.Add('y', 'b');
            cipher23.Add('z', 'c');

            //Creates cipher 24
            Dictionary<char, char> cipher24 = new Dictionary<char, char>();
            cipher24.Add('a', 'c');
            cipher24.Add('b', 'd');
            cipher24.Add('c', 'e');
            cipher24.Add('d', 'f');
            cipher24.Add('e', 'g');
            cipher24.Add('f', 'h');
            cipher24.Add('g', 'i');
            cipher24.Add('h', 'j');
            cipher24.Add('i', 'k');
            cipher24.Add('j', 'l');
            cipher24.Add('k', 'm');
            cipher24.Add('l', 'n');
            cipher24.Add('m', 'o');
            cipher24.Add('n', 'p');
            cipher24.Add('o', 'q');
            cipher24.Add('p', 'r');
            cipher24.Add('q', 's');
            cipher24.Add('r', 't');
            cipher24.Add('s', 'u');
            cipher24.Add('t', 'v');
            cipher24.Add('u', 'w');
            cipher24.Add('v', 'x');
            cipher24.Add('w', 'y');
            cipher24.Add('x', 'z');
            cipher24.Add('y', 'a');
            cipher24.Add('z', 'b');

            //Creates cipher 25
            Dictionary<char, char> cipher25 = new Dictionary<char, char>();
            cipher25.Add('a', 'b');
            cipher25.Add('b', 'c');
            cipher25.Add('c', 'd');
            cipher25.Add('d', 'e');
            cipher25.Add('e', 'f');
            cipher25.Add('f', 'g');
            cipher25.Add('g', 'h');
            cipher25.Add('h', 'i');
            cipher25.Add('i', 'j');
            cipher25.Add('j', 'k');
            cipher25.Add('k', 'l');
            cipher25.Add('l', 'm');
            cipher25.Add('m', 'n');
            cipher25.Add('n', 'o');
            cipher25.Add('o', 'p');
            cipher25.Add('p', 'q');
            cipher25.Add('q', 'r');
            cipher25.Add('r', 's');
            cipher25.Add('s', 't');
            cipher25.Add('t', 'u');
            cipher25.Add('u', 'v');
            cipher25.Add('v', 'w');
            cipher25.Add('w', 'x');
            cipher25.Add('x', 'y');
            cipher25.Add('y', 'z');
            cipher25.Add('z', 'a');

            //Creates the full cipher
            Dictionary<int, Dictionary<char, char>> fullCipher = new Dictionary<int, Dictionary<char, char>>();
            fullCipher.Add(1, cipher01);
            fullCipher.Add(2, cipher02);
            fullCipher.Add(3, cipher03);
            fullCipher.Add(4, cipher04);
            fullCipher.Add(5, cipher05);
            fullCipher.Add(6, cipher06);
            fullCipher.Add(7, cipher07);
            fullCipher.Add(8, cipher08);
            fullCipher.Add(9, cipher09);
            fullCipher.Add(10, cipher10);
            fullCipher.Add(11, cipher11);
            fullCipher.Add(12, cipher12);
            fullCipher.Add(13, cipher13);
            fullCipher.Add(14, cipher14);
            fullCipher.Add(15, cipher15);
            fullCipher.Add(16, cipher16);
            fullCipher.Add(17, cipher17);
            fullCipher.Add(18, cipher18);
            fullCipher.Add(19, cipher19);
            fullCipher.Add(20, cipher20);
            fullCipher.Add(21, cipher21);
            fullCipher.Add(22, cipher22);
            fullCipher.Add(23, cipher23);
            fullCipher.Add(24, cipher24);
            fullCipher.Add(25, cipher25);

            //Asks user for starting cipher and skip value
            Console.WriteLine("Where is the cipher starting (1-25)?");
            int cipherNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the skip number for the next word?");
            int skipNum = Int32.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Please enter your text below.");
            string userInput = Console.ReadLine().ToLower();
            string[] splitInput = userInput.Split(' ');

            string toPrint = "";
            foreach (string word in splitInput)
            {
                Dictionary<char, char> cipher = fullCipher[cipherNum];
                foreach (char character in word)
                {
                    if(cipher.ContainsKey(character))
                    {
                        toPrint += cipher[character];
                    }
                }

                toPrint += " ";
                cipherNum += skipNum;

                if(cipherNum > 25)
                {
                    cipherNum -= 25;
                }

                if(cipherNum < 1)
                {
                    cipherNum += 25;
                }
            }

            Console.WriteLine();
            Console.WriteLine(toPrint.ToUpper());
            Console.WriteLine($"Current cipher: {cipherNum}\n" +
                $"Next cipher: {cipherNum + skipNum}");
        }
    }
}
