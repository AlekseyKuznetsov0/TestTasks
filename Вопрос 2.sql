/*
	ProductsTable - таблица с продуктами, у которой id - первичный ключ и name - наименование продукта
	CategoriesTable - таблица категорий, у которой id - первичный ключ и name - наименование категории
	PrdCtgTable - таблица обеспечивающая связь много-ко-многим для продуктов и категорий, у которой пара внешних ключей id_product и id_category явлюятся составным первичным ключом
*/


--Вариант, при котором получаем все пары "Имя продукта - Имя категории", включая продукты без категорий и категории без продуктов
select 
        isnull(prd.name, '') as product_name
       ,isnull(ctg.name, '') as category_name
from ProductsTable as prd
full join PrdCtgTable as pct on prd.id = pct.id_product
full join CategoriesTable as ctg on pct.id_category = ctg.id

--Вариант, при котором получаем все пары "Имя продукта - Имя категории", включая продукты без категорий и игнорируя пустые категории.
select 
        isnull(prd.name, '') as product_name
       ,isnull(ctg.name, '') as category_name
from ProductsTable as prd
left join PrdCtgTable as pct on prd.id = pct.id_product
left join CategoriesTable as ctg on pct.id_category = ctg.id
