﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class 熊大
    {
        public string DisplayMessage { get; set; }

        public PersonEventArgs personEventArgs = new PersonEventArgs();

        public event EventHandler<PersonEventArgs> 通告熊大BeAttached;

        public 熊大(string name, double healthPoint, int level) 
        {
            this.personEventArgs.Name = name;
            this.personEventArgs.HealthPoint = healthPoint;
            this.personEventArgs.Level = level;
        }

        public void On通告熊大BeAttached(EventArgs e)
        {
            if (e is PersonEventArgs)
            {
                this.通告熊大BeAttached(this, this.personEventArgs);
            }
        }

        public void 熊大救援處理事件(object sender, EventArgs e)
        {
            if (e is PersonEventArgs)
            {
                if (this.personEventArgs.HealthPoint > 0)
                    System.Windows.MessageBox.Show(string.Format("我是{0}，正趕來幫忙", this.personEventArgs.Name));
                //else
                    //System.Windows.MessageBox.Show(string.Format("我是{0}，已陣亡", this.personEventArgs.Name));
            }
        }

        public void BeAttacked(double AttachedHealthPoint)
        {
            this.personEventArgs.HealthPoint -= AttachedHealthPoint;
            if (this.personEventArgs.HealthPoint <= 0)
            {
                this.通告熊大BeAttached = null;
                this.personEventArgs.HealthPoint = 0;
                this.DisplayMessage = "我是:" + this.personEventArgs.Name + "我被攻擊了，" + "同伴們快來救我，我的生命值只剩" + this.personEventArgs.HealthPoint;
            }
            else
                this.On通告熊大BeAttached(this.personEventArgs);

        }
    }
}
