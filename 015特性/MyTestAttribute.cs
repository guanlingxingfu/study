﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015特性
{

    //特性类的后缀以Attribute结尾
    //1.特性类的后缀以Attribute结尾
    //2.需要继承自System.Attribute
    //3.一般情况下声明为sealed
    //4.一般情况下特性类用来表示目标结构的一些状态(定义一些字段或者属性,一般不定义方法)

        [AttributeUsage(AttributeTargets.Class)]//表示该特性类可以应用到的程序结构有哪些
    sealed class MyTestAttribute : System.Attribute
        {
            
        public string Description { get; set; }
        public string VersionNumber { get; set; }
        public int ID { get; set; }

            public MyTestAttribute(string des)
            {
                this.Description = des;
            }

    }
}
