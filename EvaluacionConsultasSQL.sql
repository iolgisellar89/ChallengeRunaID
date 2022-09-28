--CONSULTAS SQL SOLICITADAS

SELECT Socios_cuenta AS Cuenta, count(TarjeNume) AS CantTarjetaPorCuenta FROM tarjetas group by Socios_cuenta 

SELECT Socios_Cuenta AS Cuenta, Marcas_Id, count(Socios_Cuenta) AS Cant_Tarjetas_Marca_Cuenta FROM tarjetas GROUP BY Socios_cuenta, Marcas_Id

SELECT Socios_Cuenta AS Cuenta, m.Nombre AS MarcaNombre, t.TarjeNume AS NumeroTarjeta, t.Tipo AS TipoTarjeta, Documento AS NumeroDocumento FROM tarjetas t INNER JOIN marcas m ON t.Marcas_Id = m.Id 
order by Socios_cuenta, Marcas_Id, Tipo

SELECT Marcas_Id, TarjeNume AS NumeroTarjeta FROM tarjetas WHERE Domi_Corres_Id IN(SELECT Id FROM domicilios WHERE Provincia = "San Luis")

UPDATE tarjetas SET Domi_Corres_Id = NULL WHERE Domi_Corres_Id in (SELECT Id FROM domicilios WHERE CodPost IS NULL)


/*Aclaración: 
Según las consideraciones a tener en cuenta, en la 1) se indica Id: 1 | Nombre: Mastercard no se podría agregar tal como lo indica ya que en modelo presentado para Nombre se asignó Varchar(8) y el nombre indicado supera el límite. 
*/
