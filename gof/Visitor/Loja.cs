using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class Loja
    {

        private List<Equipamento> eqList = new List<Equipamento>();

        public void addEquipamento(Equipamento e)
        {
            eqList.Add(e);
        }

        public List<Equipamento> getEquipamentoList()
        {
            return eqList;
        }
    }
}
