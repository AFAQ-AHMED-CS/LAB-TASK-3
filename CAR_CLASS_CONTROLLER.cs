using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LAB11_WEB_API.Models;

namespace LAB11_WEB_API.Controllers{
    public class CAR_CLASS_CONTROLLER : ApiController{
        List<CAR_CLASS> carList = new List<CAR_CLASS>(){
            new car(){ CAR_ID=1 , CAR_COLOR ="black" , CAR_MODEL =2020 , CAR_NAME ="Honda Civic" , CAR_PRICE = 4200000.0 },
            new car(){ CAR_ID=2 , CAR_COLOR ="white" , CAR_MODEL =2020 , CAR_NAME ="Mehran"      , CAR_PRICE = 950000.0 },
            new car(){ CAR_ID=3 , CAR_COLOR ="red"   , CAR_MODEL =2020 , CAR_NAME ="Honda BR V"  , CAR_PRICE = 3200000.0 },
            new car(){ CAR_ID=4 , CAR_COLOR ="white" , CAR_MODEL =2020 , CAR_NAME ="Corolla GLI" , CAR_PRICE = 3800000.0 },
            new car(){ CAR_ID=5 , CAR_COLOR ="white" , CAR_MODEL =2020 , CAR_NAME ="MERA"        , CAR_PRICE = 1200000.0 },
            new car(){ CAR_ID=6 , CAR_COLOR ="black" , CAR_MODEL =2020 , CAR_NAME ="Land Crusar" , CAR_PRICE = 30000000.0 },
            new car(){ CAR_ID=7 , CAR_COLOR ="maroon", CAR_MODEL =2020 , CAR_NAME ="Corolla Vitz", CAR_PRICE = 1800000.0 },
            new car(){ CAR_ID=8 , CAR_COLOR ="red"   , CAR_MODEL =2020 , CAR_NAME ="Corolla Aqua", CAR_PRICE = 2200000.0 },
        };
		
        public List<CAR_CLASS> Get(){
            return carList;
        }
		
        public CAR_CLASS Get(int id){
            return carList.Where(CAR_CLASS => CAR_CLASS.CAR_ID == id).FirstOrDefault();
        }

        public CAR_CLASS Post([FromBody]CAR_CLASS CAR_CLASS){
            carList.Add(car);
            return car;
        }

        public CAR_CLASS Put(int id, [FromBody]CAR_CLASS CAR_CLASS) {
            CAR_CLASS OBJ = carList.FirstOrDefault(x => x.CAR_ID == id);
            if (OBJ  != null){
                OBJ .CAR_NAME  = CAR_CLASS.CAR_NAME;
                OBJ .CAR_ID    = CAR_CLASS.CAR_ID;
                OBJ .CAR_COLOR = CAR_CLASS.CAR_COLOR;
                OBJ .CAR_MODEL = CAR_CLASS.CAR_MODEL;
                OBJ .CAR_PRICE = CAR_CLASS.CAR_PRICE;
            }
            return c;
        }

        public bool Delete(int id){
            CAR_CLASS OBJ  = carList.Where(a => a.CAR_ID == id).FirstOrDefault();
            return carList.Remove(OBJ );
        }
    }
}