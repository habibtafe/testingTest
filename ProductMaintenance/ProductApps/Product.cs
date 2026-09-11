using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        private decimal price;
        private int quantity;
        private decimal totalPayment;
        private decimal delivery;
        private decimal wrapping;
        private decimal gst;

        private decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }


        private decimal Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }


        private decimal Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        private decimal GST
        {
            get { return gst; }
            set { gst = value; }
        }

        //Constructor for Product
        public Product(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;
        }

        //Setting delivary value
        public void setDelivery(decimal delivery)
        {
            Delivery = delivery;
        }

        //Setting wrapping value
        public void setWrapping(decimal wrapping)
        {
            Wrapping = wrapping;
        }

        //Setting GST value
        public void setGST(decimal gst)
        {
            GST = gst;
        }

        //Calculator total including delivery
        public decimal TotalDelivery() {            
            return TotalPayment + Delivery;
        }

        //Calculator total including wrapping
        public decimal TotalWrapping()
        {
            return TotalDelivery() + Wrapping;
        }

        //Calculator total including GST
        public decimal TotalGST()
        {
            return TotalWrapping() * (GST+1);
        }
    }
}
