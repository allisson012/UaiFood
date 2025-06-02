using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UaiFood.BancoDeDados.UaiFood.BancoDeDados;
using UaiFood.Model;

namespace UaiFood.Controller
{
    class PedidoController
    {
        public void RegistrarPedido(int idProduto , int idCliente , int idRestaurante,decimal total,string forma_pagamento,string subTipo_pagamento)
        {
            // data pedido vou gerar na hora do registro no banco 
            // e status ao registrar vai ser em preparo e depois o restaurante ao concluir o pedido coloca como pronto
            // a ideia a na hora que for pegar os pedidos para o restaurante visualizar ele filtre entre em preparo e não mostre os concluidos
            Pedido pedido = new Pedido();
            pedido.setIdProduto(idProduto);
            pedido.setIdCliente(idCliente);
            pedido.setIdRestaurante(idRestaurante);
            pedido.setTotal(total);
            pedido.setStatus("Em preparo");
            DateTime agora = DateTime.Now;
            pedido.setDataPedido(agora);
            FormaPagamento formaPagamento = new FormaPagamento(forma_pagamento,subTipo_pagamento);
            pedido.setPagamento(formaPagamento);
            BancoDados bd = new BancoDados();
            bd.RegistrarPedido(pedido);
        }
    }
}
