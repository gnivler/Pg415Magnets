﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pg415Magnets
{
    class Flobbo
    {
        private string zap;

        public Flobbo(string zap)
        {
            this.zap = zap;
        }

        public bool Blobbo(bool Already, StreamWriter sw)
        {
            if (Already)
            {
                sw.WriteLine(zap);
                sw.Close();
                return false;
            }
            else
            {
                sw.WriteLine(zap);
                zap = "red orange";
                return true;
            }
        }

        public bool Blobbo(StreamWriter sw)
        {
            sw.WriteLine(zap);
            zap = "green purple";
            return false;
        }

        public StreamWriter Snobbo()
        {
            return new StreamWriter(@"C:\macaw.txt");
        }
    }
}

