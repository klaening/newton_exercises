using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.menus
{
    public class CoolHeader
    {
        public void PrintCoolHeader1()
        {
            string title = @"
                                           _  _
    _   __             __                 (_)(_)            _                       
   / | / /__ _      __/ /_____  ____     / __ \_   ______  (_)___  ____ _____ ______
  /  |/ / _ \ | /| / / __/ __ \/ __ \   / / / / | / / __ \/ / __ \/ __ `/ __ `/ ___/
 / /|  /  __/ |/ |/ / /_/ /_/ / / / /  / /_/ /| |/ / / / / / / / / /_/ / /_/ / /    
/_/ |_/\___/|__/|__/\__/\____/_/ /_/   \____/ |___/_/ /_/_/_/ /_/\__, /\__,_/_/     
                                                                /____/                                      
                             ";

            bool visible = true;
            for (int i = 0; i <= 2; i++)
            {
                Console.Clear();
                Console.Write("\r" + (visible ? title : new String(' ', title.Length)));
                System.Threading.Thread.Sleep(400);
                visible = !visible;
            }
        }
        public void PrintCoolHeader2()
        {
            string title = @"
                                           _  _
    _   __             __                 (_)(_)            _                       
   / | / /__ _      __/ /_____  ____     / __ \_   ______  (_)___  ____ _____ ______
  /  |/ / _ \ | /| / / __/ __ \/ __ \   / / / / | / / __ \/ / __ \/ __ `/ __ `/ ___/
 / /|  /  __/ |/ |/ / /_/ /_/ / / / /  / /_/ /| |/ / / / / / / / / /_/ / /_/ / /    
/_/ |_/\___/|__/|__/\__/\____/_/ /_/   \____/ |___/_/ /_/_/_/ /_/\__, /\__,_/_/     
                                                                /____/                                      
                             ";

            Console.WriteLine(title);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
