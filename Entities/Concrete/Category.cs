using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
       //ŞÖYLEKİ BİZİM ÇIPLAK CLASSIMIZ KALMAMASI GEREK. KALIRSA PROJELER BÜYÜDÜKÇE SORUN YAŞARIZ. 
       //PROBLEM YAŞAMAMAK İÇİN İSE SAĞ TARAFTA ABSTRACT DOSYASINDA IEntity ADINDA INTERFACE AÇTIK. GEREKLİ ALANLARDA KULLANAK İÇİN.
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
