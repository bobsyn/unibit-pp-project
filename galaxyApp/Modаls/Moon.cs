using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyCatalog.Modals
{
    public class Moon: ICountList
    {
        // Полета

        private string moonName;
        static int instances = 0;

        // Конструктори

        public Moon(string moonName)
        {
            this.moonName = moonName;

            instances++;
        }

        // Свойства

        public string MoonName {
            get { return this.moonName;  }
        }

        // Методи

        public static int GetActiveInstances()
        {
            return instances;
        }
        int ICountList.GetActiveInstances()
        {
            return Moon.GetActiveInstances();
        }

        public string GetInnerList(string view)
        {
            return "";
        }


        public override string ToString()
        {
            return this.moonName;
        }

    }
}
