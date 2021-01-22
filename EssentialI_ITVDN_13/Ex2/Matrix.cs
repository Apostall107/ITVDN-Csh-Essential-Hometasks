using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;



namespace EssentialI_ITVDN_13
{

    class Matrix
    {
        #region Fields
        Random rnd; // = new Random((int)DateTime.Now.Ticks);

        static object block = new object();

        char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'V', 'X', 'Y', 'Z' };

        int column_num;

        int X = Program.X,
            Y = Program.Y;


        int stream_max_lenght,
            stream_current_lenght,
            additional_Threads_count = 0;


        #endregion

        public Matrix(int col)
        {
            this.column_num = col;                     // column/position of instance
            this.rnd = new Random((int)DateTime.Now.Ticks);// initialize randomizer for this instance
        }

        char Get_Char()//returns randon char pron alphabet array
        {
            return alphabet[rnd.Next(0, alphabet.Length - 1)];
        }

        public void Char_Stream_Drop()
        {
            while (true)
            {


                this.stream_current_lenght = 0;
                this.stream_max_lenght = rnd.Next(3, 8);

                Thread.Sleep(rnd.Next(0, 800));
                for (int i = 0; i < Y; i++)
                {
                    lock (block)
                    {
                        Initialize_Blank_Field_byColumns();

                        Set_Start_Cursor();

                        Stream_Sizes_Check(i);

                      //  Additional_Threads_Creator(i);

                        Get_Stream(i);


                    }
                }


            }
        }


        void Get_Stream(int i)
        {
            Get_Stream_Tail(i);
            Get_Sream_2nd_Char(i);
            Get_Stream_1st_Char(i);
        }

        void Get_Stream_Tail(int i)
        {
            bool flag = false;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (stream_current_lenght > 2)
            {
                for (int j = stream_current_lenght - 2; j>=0;j--)
                {
                    if (flag == false)
                    {
                        for (int c = i - 1; c >= 0; c--)
                        {
                            Console.CursorTop = c;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("█");
                        }
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        flag = true;
                    }
                    Console.CursorTop = i++;
                    Console.CursorLeft = column_num;
                    Console.WriteLine(Get_Char());
                }
            }
            Console.ResetColor();
            
        }

        void Get_Sream_2nd_Char(int i)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (stream_current_lenght > 1)
            {
                Console.CursorTop = i++;
                Console.CursorLeft = column_num;
                Console.WriteLine(Get_Char());
            }
            Console.ResetColor();
        }

        void Get_Stream_1st_Char(int i)
        {
            Console.ForegroundColor = ConsoleColor.White;
            if (stream_current_lenght > 0)
            {
                Console.CursorTop = i++;
                Console.CursorLeft = column_num;
                Console.WriteLine(Get_Char());
            }

            Console.ResetColor();
        }


        void Additional_Threads_Creator(int i)
        {
            if (i > 8 && additional_Threads_count != 0)
            {
                new Thread(() => { new Matrix(column_num).Char_Stream_Drop(); }).Start();
                additional_Threads_count--;
            }
        }

        void Stream_Sizes_Check(int i)
        {
            if (stream_current_lenght < stream_max_lenght)//if current lenth is lower than max increase its lenth (entering the field)
            {
                stream_current_lenght++;
            }
            else if (stream_current_lenght == stream_max_lenght) // if max size achieved  reset the size to prefent increasing of length in the end

                if (Y - 1 - i < stream_current_lenght) // going past end of field
                {
                    stream_current_lenght--;
                }
        }

        void Set_Start_Cursor()
        {
            Console.CursorTop = 0;
            Console.CursorLeft = this.column_num;
        }

        void Initialize_Blank_Field_byColumns()//every threat have to fill its column
        {
            Console.ForegroundColor = ConsoleColor.Black;
            for (int i = 0; i < Y+10; i++)
            {
                Set_Start_Cursor();
                Console.WriteLine("█");  //ASCII 219  (alt + 219) => █ 
            }
            Console.ResetColor();
        }



    }

}
