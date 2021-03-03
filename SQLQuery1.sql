--SQL, case insensitive - büyük küçük harf duyarsız
--Select
Select * from Customers /*Customers tablosundan tüm kolonları getir*/

Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers /*Customers tablosunun 3 kolonunu getir*/

--Where																		/*Bu şekilde isim farklılığıyla getirmeye Alias deniyor*/
Select * from Customers where City = 'London'

select * from Products where categoryId=1 or categoryId=3

select * from Products where categoryId=1 and UnitPrice>=10


--Order by
select * from Products order by ProductName /*order by=sırala, ProductName'e göre sıralar*/

select * from Products order by CategoryID /*CategoryId'ye göre sıralar*/
select * from Products order by CategoryID,ProductName /*CategoryId'leri kendi arasında ProductName'e göre sıralar*/

select * from Products order by UnitPrice asc /* ascending - fiyata göre artan şeklinde sıralar*/
select * from Products order by UnitPrice desc /* descending - fiyata göre azalan(düşen) şeklinde sıralar*/

select * from Products where categoryId=1 order by UnitPrice desc /*categoryId=1 olanları filtreler ve fiyata göre azalan şeklinde sıralar*/

--count(*)
Select count(*) from Products /* Products tablosundaki dataları sayar*/
Select count(*) from Products where CategoryID = 2
Select count(*) Adet from Products where CategoryID = 2 /*Alias yaparak kolon adını Adet yapmış oluruz*/

--Group by
Select * from Products group by CategoryID /*bu çalışmayan bir koddur.*/

Select categoryId from products group by CategoryId

Select categoryId from products group by CategoryId /*bütün kategorielri tekrar etmeyecek şekilde bana listele demektir*/

Select categoryId,count(*) from products group by CategoryId /*burada artık her kategoride kaç ürün olduğunu sayıp tabloya yazacaktır.*/
															/*group by sayesinde her bir grup elemanı için ayrıca count hesaplanıyor*/

Select categoryId,count(*) from products group by CategoryId having count(*)<10  /*içerisinde 10 taneden az ürün olan kategorileri getirir*/

Select categoryId,count(*) from products where UnitPrice>20 group by CategoryId having count(*)<10  /*önce where çalışır - unitPrice'ı 20 den fazla olan ürünleri getirir ve bunların da kategoriye göre ürün adedi 10 dan az olanları tabloya yazar*/


--Join
--inner join - sadece iki tabloda da eşleşen verileri bir araya getirir eşleşmeyen data varsa onu getirmez
Select * 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID

Select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID

Select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10


--DTO Data Transformation Object : C#'taki join'li yapılarla oluşturduğumuz class'lar

Select * from Products p inner join [Order Details] od
on p.ProductId = od.ProductId

/*Yönetim hiç satış yapamadığımız ürünleri görmek istiyor*/

Select * from Products p left join [Order Details] od   /*solda olup sağda olmayanları da getir (p'de olup od'de olmayanlar)*/
on p.ProductId = od.ProductId

/*sisteme kayıtlı ama hiç sipariş vermemiş olan müşterileri getirmek için */
Select * from Customers c left join Orders o 
on c.CustomerID = o.CustomerID
where o.CustomerID is  null   /* PK null olamayacağı için bunu genelde PK'ya uygularız*/

Select * from Products p inner join [Order Details] od   
on p.ProductId = od.ProductId
inner join Orders o			/*daha fazla eklemeyi bu şekilde yapabiliriz*/
on o.OrderID = od.OrderID


Select p.ProductName as 'UrunAdi' , sum(od.quantity * p.unitprice) as 'ToplamMiktar'
from ((Products as p inner join [Order Details] as od  
on p.ProductID = od.ProductID) inner join Orders as o on o.OrderID = od.OrderID)
group by p.ProductName

