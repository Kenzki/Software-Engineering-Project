--Kenneth Malon--
--This Creates DVDSYS Table--

DELETE FROM RentedItems;
DELETE FROM Transactions;
DELETE FROM Rentals;
DELETE FROM DVDs;
DELETE FROM Members;
DELETE FROM Rates;


INSERT INTO Rates
VALUES('NR','NEW RELEASE',9.99);
INSERT INTO Rates
VALUES('OR','OLR RELEASE',4.99);
INSERT INTO Rates
VALUES('CH','CHILDREN',2.99);


INSERT INTO DVDs
VALUES(101,'Thor: Ragnarok','xxxx',2017,'NR','A','AR');
INSERT INTO DVDs
VALUES(102,'Thor: Ragnarok 2','yyyy',2018,'NR','NA','AR');
INSERT INTO DVDs
VALUES(103,'Harry Potter','zzzz',1997,'OR','A','R');
INSERT INTO DVDs
VALUES(104,'Lion King','wwww',2017,'CH','A','R');
INSERT INTO DVDs
VALUES(106,'Captain Marvel','aaaa',2018,'NR','A','R');
INSERT INTO DVDs
VALUES(107,'Dead Pool','bbbb',1998,'OR','A','R');
INSERT INTO DVDs
VALUES(108,'Spider Man: Home Coming','cccc',2017,'NR','A','R');
INSERT INTO DVDs
VALUES(109,'The Guardian of the Galaxy','dddd',1997,'OR','A','AR');
INSERT INTO DVDs
VALUES(110,'Test','dddd',2017,'NR','A','AR');


INSERT INTO Members
VALUES(101,'Kenneth Malon','ken@ymail.ie','New Street','Killarney',0838327088,'A','03-FEB-2018');
INSERT INTO Members
VALUES(102,'Jack Teahan','tea@ymail.com','Old Street','Tralee',0882312345,'D','07-JULY-2017');
INSERT INTO Members
VALUES(103,'Petrit Krasniqi','petrir@hotmail.com','High Street','Cork',0831234567,'A','21-JAN-2018');
INSERT INTO Members
VALUES(104,'Peirce Price','pirce@hotmail.com','Park Drive','Cork',0831234123,'A','21-FEB-2018');
INSERT INTO Members
VALUES(105,'Keiran Connor','keiran@ymail.ie','New Street','Killarney',0838327123,'A','06-APR-2018');
INSERT INTO Members
VALUES(106,'Ashley McCLoud','ashleyCloud@ymail.com','Buefort Street','Buefort',083123456,'A','01-MAY-2018');
INSERT INTO Members
VALUES(107,'Test','test@ymail.com','Test','Test',0831234567,'A','01-MAY-2018');


INSERT INTO Rentals
VALUES(101,'Kenneth Malon',101,'23-APR-2018','30-APR-2018');
INSERT INTO Rentals
VALUES(102,'Keiran Connor',105,'22-APR-2018','30-APR-2018');
INSERT INTO Rentals
VALUES(103,'Peirce Price',104,'01-MAY-2018','08-MAY-2018');
INSERT INTO Rentals
VALUES(104,'Petrit Krasniqi',103,'01-MAY-2018','08-MAY-2018');


INSERT INTO RentedItems
VALUES(101,103);
INSERT INTO RentedItems
VALUES(102,106);
INSERT INTO RentedItems
VALUES(103,107);
INSERT INTO RentedItems
VALUES(104,104);
INSERT INTO RentedItems
VALUES(104,108);


INSERT INTO Transactions
VALUES(101,101,101,'Payment','23-APR-2018',4.99);
INSERT INTO Transactions
VALUES(102,105,102,'Payment','22-APR-2018',9.99);
INSERT INTO Transactions
VALUES(103,105,102,'Overdue','30-APR-2018',3.99);
INSERT INTO Transactions
VALUES(104,104,103,'Payment','01-MAY-2018',4.99);
INSERT INTO Transactions
VALUES(105,103,104,'Payment','01-MAY-2018',14.98);

COMMIT;




