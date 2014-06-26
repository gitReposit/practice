using System;

namespace AsimTraders
{
    class Dates
    {
        public static string dtt = "0", dtw, dtm;
        public static DateTime datt, datw, datm;

        public static void setspan()
        {
            DateTime tempt = Convert.ToDateTime("2010-05-28");
            DateTime tempw = Convert.ToDateTime("2010-05-21");
            DateTime tempm = Convert.ToDateTime("2010-04-28");

            datt = DateTime.Now;

            dtt = DateTime.Now.ToString("yyyy-MM-dd");

            TimeSpan tspanw = tempt - tempw;
            datw = datt - tspanw;
            dtw = datw.ToString("yyyy-MM-dd");


            TimeSpan tspanm = tempt - tempm;
            datm = datt - tspanm;
            dtm = datm.ToString("yyyy-MM-dd");
        }

        public static string MakeCriteria(int si)
        {
            string criteria = "";
            setspan();
            if (si == 1)
                criteria += "between '" + Dates.dtw + "' and '" + Dates.dtt + "'";
            else
                if (si == 2)
                    criteria += "between '" + Dates.dtm + "' and '" + Dates.dtt + "'";
                else
                    if (si == 3)
                        criteria += "= '" + Dates.dtt + "'";
            return criteria;
        }
    }
}

