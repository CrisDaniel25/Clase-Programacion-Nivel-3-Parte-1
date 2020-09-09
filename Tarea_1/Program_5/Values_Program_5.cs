using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_1.Program_5
{
    class Values_Program_5 : Program_3.Values_Program_3
    {
        public string Name = "";
        public string Last_Name;
        public string Phone_Number;

        public string Path = "C:\\HTML";

        public string HTML()
        {
            return  "<html>" +
            "<head>" +
            "<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>" +
            "</head>" +
            "<body>" +
            "<table class='table table-striped table - dark'>" +
            "<thead>" +
            "<tr>" + 
            "<th scope='col'>" +"Name:" + "</th>" +
            "<th scope='col'>" + "Last Name:" + "</th>" +
            "<th scope='col'>" + "Phone Number:" + "</th>" +
            "</tr>" +
            "</thead>" +
            "<tbody>" +
            "<tr>" +
            "<th>" + Name + "</th>" +
            "<th>" + Last_Name + "</th>" +
            "<th>" + Phone_Number + "</th>" +
            "</tr>" +
            "</tbody>" +
            "</table>" +
            "</body>" +
            "</html>";
        } 
    }
    
}
 