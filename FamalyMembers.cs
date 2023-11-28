using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1Спроектируйте программу для построения генеалогического дерева.
// Учтите что у нас есть члены семьи у кого нет детей(дет).
// Есть члены семьи у кого дети есть (взрослые). Есть мужчины и женщины.
/*2Доработать предыдущий класс реализовав методы вывода родителей, детей, братьев/сестер (включая двоюродных), 
 * бабушеки дедушек. Подумайте как лучше реализовать данные методы.*/

namespace Practika241123
{
    internal class FamalyMembers
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; } = 0;
        public Gender Gender { get; set; }
        public FamalyMembers Mother { get; set; }
        public FamalyMembers Father { get; set; }
        public FamalyMembers Spouse { get; set; } 
        public FamalyMembers[] GetGrandMotherName()
        {
            return new FamalyMembers[] { Mother?.Mother, Father?.Mother };

        }
        public FamalyMembers[] GetGrandFatherName()
        {
            return new FamalyMembers[] { Father?.Mother, Father?.Father };
        }
    }
    enum Gender { man, woman }
}
