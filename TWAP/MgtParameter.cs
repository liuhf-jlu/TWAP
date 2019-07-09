using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWAP
{
    /// <summary>
    /// 面源参数类
    /// </summary>
    class MgtParameter
    {
         //种植参数
         public string crop; 
         public int plant_month;
         public int plant_day;
         public double plant_husc;
         public int plant_mgt_op;
         public int plant_id;
         public int curyr_mat;
         public double heat_units;
         public double lai_init;
         public double hi_targ;
         public double bio_init;
         public double bio_targ;
         public double plant_cnop;
       
        //灌溉参数
         public int irr_month;
         public int irr_day;
         public double irr_husc;
         public int irr_mgt_op;
         public double irr_amt;
         public double irr_salt;
         public double irr_efm;
         public double irr_sq;
         public double irr_sc;  //09手册上没有
         public double irr_no;  //09手册上没有

        //施肥参数
         public int frt_month;
         public int frt_day;
         public double frt_husc;
         public int frt_mgt_op;
         public int fert_id;
         public string fert_name;
         public double frt_kg;
         public double frt_surface;

        //收割操作
         public int harv_month;
         public int harv_day;
         public double harv_husc;
         public int harv_mgt_op;
         public double harv_cnop;
    }
}
