
-- select * from clientes;


-- dml - manipulação ( select, insert, delete, update)
-- ddl - definição (create, alter,drop) 
-- plsql - 

use comercialdb0191
--   drop PROCEDURE sp_cliente_inserir;


delimiter |
CREATE PROCEDURE sp_cliente_inserir(
_nome varchar(60),
_cpf varchar(11),
_email varchar(60)
)
BEGIN
	insert into clientes (nome, cpf, email, datacad, ativo)
    values (_nome,_cpf,_email, default, default);
    select * from clientes where idcli = (select @@identity);
END
|

select * from clientes;
delete from clientes where idcli = 1;nomeclientesnomelnome
select * from clientes;


delimiter |
CREATE PROCEDURE sp_cliente_alterar(
_id int,
_nome varchar(60),
_email varchar(60)
)
BEGIN
 update clientes set nome = _nome, email = _email where idcli = _id;
 END
 |

select * from clientes where idcli;

insert usuarios (nome, email, senha, nivel, ativo) values ('jose', 'joseedudu@gmail.com', md5('123456'), default, default;
select * from usuarios;

 -- ---------------------------------------
               -- -usuarios---
delimiter |
CREATE PROCEDURE sp_usuario_inserir(
_nome varchar(60),
_email varchar(60),
_senha varchar(32),
_nivel varchar(15)
)
BEGIN
	insert into usuarios (nome, email, senha, nivel, ativo)
    values (_nome, _email, md5(_senha), _nivel, default);
    select * from usuarios where iduser = (select @@identity);
END
|


delimiter |
CREATE PROCEDURE sp_usuario_alterar(
_iduser int,
_nome varchar(60),
_email varchar(60),
_senha varchar(32),
_nivel varchar(15)
)
BEGIN
 update usuarios set nome = _nome, email = _email, senha = md5(_senha), nivel = _nivel where iduser = _id;
 END
 |
 
 -- ---------------------------------------
			  -- -pedidos---
delimiter |
CREATE PROCEDURE sp_pedidos_inserir(
_status_ped varchar(15),
_desconto decimal(10,2),
_iduser_ped int,
_idcli_ped int
)
BEGIN
	insert into pedidos (data, status_ped, desconto, iduser_ped, idcli_ped)
    values (default, _status_ped, _desconto, _iduser_ped, _idcli_ped);
    select * from pedidos where idped = (select @@identity);
END
|


delimiter |
CREATE PROCEDURE sp_pedido_alterar(
_id int,
_status_ped varchar(15),
_desconto decimal(10,2)
)
BEGIN
 update pedidos set status_ped = _status_ped, desconto = _desconto where idped = _id;
 END
 |
 --  ---------------------------------------
			  -- -produtos---
 delimiter |
CREATE PROCEDURE sp_produtos_inserir(
_descricao varchar(100),
_unidade varchar(14),
_codbar char(13),
_valor decimal(10,2)
)
BEGIN
	insert into produtos (descricao, unidade, codbar, valor, desconto, descontinuado)
    values (_descricao, _unidade, _codbar, _valor, 0, default);
    select * from produtos where idprod = (select @@identity);
END
|


delimiter |
CREATE PROCEDURE sp_produto_alterar(
_id int,
_valor decimal(10,2),
_desconto decimal(10,2)
)
BEGIN
 update produtos set valor = _valor, desconto = _desconto  where idprod = _id;
 END
 |
 
 -- ---------------------------------------
			-- -item pedido---
  delimiter |
CREATE PROCEDURE sp_itempedido_inserir(
_idped_ip int,
_idprod_ip int,
_valor decimal(10,2),
_quantidade decimal(10,2),
_desconto decimal(10,2)
)
BEGIN
	insert into itempedido (idped_ip, idprod_ip, valor, quantidade, desconto)
    values (_idped, _idprod, _valor, _quantidade, _desconto);
END
|


delimiter |
CREATE PROCEDURE sp_itempedido_alterar(
_idped_ip int,
_idprod_ip int,
_valor decimal(10,2),
_quantidade decimal(10,2),
_desconto decimal(10,2)
)
BEGIN
 update itempedido set valor = _valor, quantidade = _quantidade, desconto = _desconto where idped = _idped and iprod = _iprod;
 END
 |
 -- ---------------------------------------
			   -- -caixas---
   delimiter |
CREATE PROCEDURE sp_caixas_inserir(
_caixascol decimal(10,2),
_status_caixa varchar(32),
_iduser_cx int

)
BEGIN
	insert into caixas (data_abertura, caixascol, status_caixa, iduser_cx)
    values (default, _caixascol, _status_caixa, _iduser);
     select * from caixa where idcx = (select @@identity);
END
|


delimiter |
CREATE PROCEDURE sp_caixas_alterar(
_id int,
_caixascol decimal(10,2),
_status_caixa varchar(32),
_iduser_cx int
)
BEGIN
 update caixas set caixascol = _caixascol, status_caixa = _status_caixa where idcx = _id;
 END
 |
  -- ---------------------------------------
				-- -vendas---
   delimiter |
CREATE PROCEDURE sp_vendas_inserir(
_status_vnd varchar(15),
_desconto decimal(10,2),
_idcx_vnd int,
_idped_vnd int
)
BEGIN
	insert into vendas (data_vnd, status_vnd, desconto, idcx_vnd, idped_vnd)
    values (default, _status_vnd, _desconto, _idcx, _idped);
     select * from vendas where idvnd = (select @@identity);
END
|

delimiter |
CREATE PROCEDURE sp_vendas_alterar(
_id int,
_status_vnd varchar(15),
_desconto decimal(10,2)
)
BEGIN
 update vendas set status_vnd = _status_vnd, desconto = _desconto  where idvnd = _id;
 END
 |
   -- ---------------------------------------
              -- -pagamentos---
      delimiter |
CREATE PROCEDURE sp_pagamentos_inserir(
_valor decimal(10,2),
_idvnd_pag int,
_idtipo_pag int
)
BEGIN
	insert into pagamentos (valor, idvnd_pag, idtipo_pag)
    values (_valor, _idvnd, _idtipo);
     select * from pagamentos where idpag = (select @@identity);
END
|

delimiter |
CREATE PROCEDURE sp_pagamentos_alterar(
_id int,
_valor decimal(10,2)
)
BEGIN
 update pagamentos set valor = _valor  where idpag = _id;
 END
 |
   -- ---------------------------------------
		     -- -tipos pagamento---
       delimiter |
CREATE PROCEDURE sp_tipospag_inserir(
_nome varchar(20),
_sigla varchar(10)
)
BEGIN
	insert into tipospag (nome, sigla)
    values (_nome, _sigla);
     select * from tipospag where idtipo = (select @@identity);
END
|

delimiter |
CREATE PROCEDURE sp_tipospag_alterar(
_id int,
_nome varchar(20),
_sigla varchar(10)
)
BEGIN
 update tipospag set nome = _nome, sigla = _sigla where idtipo = _id;
 END
 |
 
call sp_produtos_inserir('Amortecedor dianteiro Kofap para Onix', 'per', '9345895478321', 376.97);


 select * from clientes;
  