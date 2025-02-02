﻿using SQLite;


namespace Project_Invoice_MAUI.DTOContex
{
    public class GoodsDTO
    {
        public string Product_Name { get; set; }

        [PrimaryKey]
        public string Product_Code { get; set; }
        public int Product_Id { get; set; }
        public string Description { get; set; }
        public double Price_Netto { get; set; }
        public double Price_Brutto { get; set; }
        public double Sum { get; set; }
        public double VAT { get; set; }
        public string VAT_String { get; set; }
        public bool IsSelected { get; set; }
        public int Quantity { get; set; }
    }
}
