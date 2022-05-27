using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ЕкзаменаційнеЗавданняБілет_2
{
    public class Parachute
    {
        public Parachute(){}
        public int Weight;
        
        public int CheckWeight(int inputWeight)
        {
            if (inputWeight != null && inputWeight >= 40 && inputWeight <= 95)
            {
                Weight = inputWeight;
                return Weight;
            }
            return Weight;
        }

        public string ReturnParachuteType(int inputNumberOfPeople)
        {
            if (inputNumberOfPeople != null)
            {
                if (inputNumberOfPeople == 1)
                {
                    return ParachuteType.SportParachute;
                }
                else if (inputNumberOfPeople == 2)
                {
                    return ParachuteType.Parachute;
                }
                else
                {
                    Console.WriteLine("Invalid number of people");
                }
            }

            return string.Empty;
        }

        public bool ReturnWindSpeed(int inputWind)
        {
            if (inputWind != null && inputWind > 5)
            {
                return true;
            }

            return false;
        }

        public bool HeightForJump(int height)
        {
            if (height >= 4200)
            {
                return true;
            }

            return false;
        }
    }
}
