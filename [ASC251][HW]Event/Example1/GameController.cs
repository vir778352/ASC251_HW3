using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class GameController
    {
        熊大 熊大;
        詹姆士 詹姆士;
        鰻頭人 鰻頭人;
        兔兔 兔兔;
        Random random;
        public string[] personInfomation = new string[4]; 
        public string DisplayMessage { get; set; }

        public GameController()
        {
            random = new Random();
            熊大 = new 熊大("熊大", 1000, 9);
            詹姆士 = new 詹姆士("詹姆士", 1000, 10);
            鰻頭人 = new 鰻頭人("鰻頭人", 1000, 8);
            兔兔 = new 兔兔("兔兔", 1000, 12);
            熊大.通告熊大BeAttached += new EventHandler<PersonEventArgs>(詹姆士.詹姆士救援處理事件);
            熊大.通告熊大BeAttached += new EventHandler<PersonEventArgs>(鰻頭人.鰻頭人救援處理事件);
            熊大.通告熊大BeAttached += new EventHandler<PersonEventArgs>(兔兔.兔兔救援處理事件);
            詹姆士.通告詹姆士BeAttached += new EventHandler<PersonEventArgs>(熊大.熊大救援處理事件);
            詹姆士.通告詹姆士BeAttached += new EventHandler<PersonEventArgs>(鰻頭人.鰻頭人救援處理事件);
            詹姆士.通告詹姆士BeAttached += new EventHandler<PersonEventArgs>(兔兔.兔兔救援處理事件);
            鰻頭人.通告鰻頭人BeAttached += new EventHandler<PersonEventArgs>(熊大.熊大救援處理事件);
            鰻頭人.通告鰻頭人BeAttached += new EventHandler<PersonEventArgs>(詹姆士.詹姆士救援處理事件);
            鰻頭人.通告鰻頭人BeAttached += new EventHandler<PersonEventArgs>(兔兔.兔兔救援處理事件);
            兔兔.通告兔兔BeAttached += new EventHandler<PersonEventArgs>(熊大.熊大救援處理事件);
            兔兔.通告兔兔BeAttached += new EventHandler<PersonEventArgs>(鰻頭人.鰻頭人救援處理事件);
            兔兔.通告兔兔BeAttached += new EventHandler<PersonEventArgs>(詹姆士.詹姆士救援處理事件);

        }

        public void PlayGame()
        {
            
            Boolean isPersonAttatched = false;
            while (!isPersonAttatched)
            {
                int randomNumber = random.Next(0, 4);
                if (randomNumber == 0 && 熊大.personEventArgs.HealthPoint > 0)
                {
                        熊大.BeAttacked(random.Next(500, 1000));
                        this.DisplayMessage = 熊大.DisplayMessage;
                        isPersonAttatched = true;
                }
                else if (randomNumber == 1 && 詹姆士.personEventArgs.HealthPoint > 0)
                {
                        詹姆士.BeAttacked(random.Next(500, 1000));
                        this.DisplayMessage = 詹姆士.DisplayMessage;
                        isPersonAttatched = true;
                }
                else if (randomNumber == 2 && 鰻頭人.personEventArgs.HealthPoint > 0)
                {
                        鰻頭人.BeAttacked(random.Next(500, 1000));
                        this.DisplayMessage = 鰻頭人.DisplayMessage;
                        isPersonAttatched = true;
                }
                else if (randomNumber == 3 && 兔兔.personEventArgs.HealthPoint > 0)
                {
                        兔兔.BeAttacked(random.Next(500, 1000));
                        this.DisplayMessage = 兔兔.DisplayMessage;
                        isPersonAttatched = true;
                }
                else if (熊大.personEventArgs.HealthPoint == 0 && 詹姆士.personEventArgs.HealthPoint == 0 && 鰻頭人.personEventArgs.HealthPoint == 0 && 兔兔.personEventArgs.HealthPoint == 0)
                {
                    isPersonAttatched = true;
                    this.DisplayMessage = "Game Over!!";
                }
                
            }
        }

        public void UpdateUI()
        {
            this.personInfomation[0] = "我是:" + 熊大.personEventArgs.Name + "\n生命值:" + 熊大.personEventArgs.HealthPoint + "\n等級:" + 熊大.personEventArgs.Level;
            this.personInfomation[1] = "我是:" + 詹姆士.personEventArgs.Name + "\n生命值:" + 詹姆士.personEventArgs.HealthPoint + "\n等級:" + 詹姆士.personEventArgs.Level;
            this.personInfomation[2] = "我是:" + 鰻頭人.personEventArgs.Name + "\n生命值:" + 鰻頭人.personEventArgs.HealthPoint + "\n等級:" + 鰻頭人.personEventArgs.Level;
            this.personInfomation[3] = "我是:" + 兔兔.personEventArgs.Name + "\n生命值:" + 兔兔.personEventArgs.HealthPoint + "\n等級:" + 兔兔.personEventArgs.Level;
        }
    }
}
