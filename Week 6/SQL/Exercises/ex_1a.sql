use TestTraining

---------------------------------------------------------------------------------------------------------------
-- From the following tables write a SQL query to find the salesperson and customer who belongs to same city.--
-- Return Salesman, cust_name and city.                                                                      --
---------------------------------------------------------------------------------------------------------------
--drop table exercise_1a_salesman
create table exercise_1a_salesman (
	salesman_id int constraint ex_1a_sale_primary primary key,
	[name] varchar(50),
	city varchar(50),
	commission float
);
--drop table exercise_1a_customer
create table exercise_1a_customer (
	customer_id int constraint ex_1a_cust_primary primary key,
	cust_name varchar(50),
	city varchar(50),
	grade int,
	salesman_id int constraint ex_1a_cust_foreign_sales foreign key references exercise_1a_salesman(salesman_id) on delete cascade
);

insert into exercise_1a_salesman values 
			(5001, 'James Hoog', 'New York', 0.15), (5002, 'Nail Knite', 'Paris', 0.13), (5005, 'Pit Alex', 'London', 0.11),
			(5006, 'Mc Lyon', 'Paris', 0.14), (5007, 'Paul Adam', 'Rome', 0.13), (5003, 'Lauson Hen', 'San Jose', 0.12)

insert into exercise_1a_customer values 
			(3002, 'Nick Rimando', 'New York', 100, 5001), (3007, 'Brad Davis', 'New York', 200, 5001), 
			(3005, 'Grahan Zusi', 'California', 200, 5002), (3008, 'Julian Green', 'London', 300, 5002),
			(3004, 'Fabian Johnson', 'Paris', 300, 5006), (3009, 'Geoff Cameron', 'Berlin', 100, 5003),
			(3003, 'Jozy Altidor', 'Moscow', 200, 5007)



---------------------------------------------------------------------------------------------------------------------
-- From the following tables write a SQL query to find those orders where order amount exists between 500 and 2000.--
-- Return ord_no, purch_amt, cust_name, city.                                                                      --
---------------------------------------------------------------------------------------------------------------------

--drop table excercise_1b_orders
create table exercise_1b_orders (
	ord_no int constraint ex_1a_ord_primary primary key,
	purch_amt float,
	ord_date date, 
	customer_id int constraint ex_1b_ord_foreign_cust foreign key references exercise_1a_customer(customer_id),
	salesman_id int constraint ex_1b_ord_foreign_sales foreign key references exercise_1a_salesman(salesman_id)
)

insert into exercise_1b_orders values 
			(70001, 150.5, '2012-10-05', 3005, 5002), (70009, 270.65, '2012-09-10', 3008, 5005), 
			(70002, 65.26, '2012-10-05', 3002, 5001), (70004, 110.5 , '2012-09-19', 3005, 5002),
			(70007, 948.5, '2012-09-10', 3005, 5002), (70005, 2400.6, '2012-07-27', 3007, 5001)



----------------------------------------------------------------------------------------------------------
-- From the following tables write a SQL query to find the salesperson(s) and the customer(s) he handle.--
-- Return Customer Name, city, Salesman, commission.                                                    --
----------------------------------------------------------------------------------------------------------




  Sample table: customer
  customer_id |   cust_name    |    city    | grade | salesman_id 
-------------+----------------+------------+-------+-------------
        3002 | Nick Rimando   | New York   |   100 |        5001
        3007 | Brad Davis     | New York   |   200 |        5001
        3005 | Graham Zusi    | California |   200 |        5002
        3008 | Julian Green   | London     |   300 |        5002
        3004 | Fabian Johnson | Paris      |   300 |        5006
        3009 | Geoff Cameron  | Berlin     |   100 |        5003
        3003 | Jozy Altidor   | Moscow     |   200 |        5007
        
  Sample table: salesman
  
   salesman_id |    name    |   city   | commission 
-------------+------------+----------+------------
        5001 | James Hoog | New York |       0.15
        5002 | Nail Knite | Paris    |       0.13
        5005 | Pit Alex   | London   |       0.11
        5006 | Mc Lyon    | Paris    |       0.14
        5007 | Paul Adam  | Rome     |       0.13
        5003 | Lauson Hen | San Jose |       0.12