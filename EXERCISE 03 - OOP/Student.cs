using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCISE_03___OOP{
    //----------------------START | OBJ STUDENT------------------------//
    class Student{
        public string Name;
        public double Grade1, Grade2, Grade3;
        //------------------------ MET. CLASS -------------------------------//
        public double FinalGrade(){
            return Grade1 + Grade2 + Grade3;
        }
        public bool Approved() { 
            if (FinalGrade() >= 60){
                return true;
            }
            else{
                return false;
            }
        }
        public double RemainingGrade(){
            if (Approved()){
                return 0;
            }
            else {
                return 60 - FinalGrade();
            }
        }
    }
    //--------------------------- END --------------------------------// 
}
