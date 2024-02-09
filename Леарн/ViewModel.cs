using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Леарн
{
    public partial class Service
    {
        public bool sale { get => Discount != null; }
        public SolidColorBrush SaleColor
        {
            get
            {
                if (sale)
                {
                    return Brushes.GreenYellow;
                }
                else
                {
                    return Brushes.White;
                }

            }
        }
        public string SaleText
        {
            get
            {
                if (sale)
                {
                    return "Visible";
                }
                else
                {
                    return "Hidden";
                }

            }
        }
        public string SaleDecor
        {
            get
            {
                if (sale)
                {
                    return "Strikethrough";
                }
                else
                {
                    return "None";
                }

            }
        }
    }
    public class Services
    {
        public List<Service> usr;
        public Services()
        {
            usr = newServices();
        }

        public List<Service> newServices()
        {
            List<Service> services = new List<Service>();
            Service buff;
            List<Service> bdServices= Base.dataBase.Service.ToList();

            foreach (Service service in bdServices)
            {
                buff = new Service();
                buff.ID = service.ID;
                buff.Title = service.Title;
                buff.Cost = service.Cost;
                buff.DurationInSeconds = service.DurationInSeconds/60;
                buff.Discount = service.Discount*100;
                buff.MainImagePath = service.MainImagePath;
                services.Add(buff);
            }
            return services;
        }
    }
}
