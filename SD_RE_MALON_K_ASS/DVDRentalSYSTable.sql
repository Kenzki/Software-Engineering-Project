-- Kenneth Malon
-- DVDRentalSys.sql
-- This script creates the DVDSYS database--

DROP TABLE RentedItems;
DROP TABLE Transactions;
DROP TABLE Rentals;
DROP TABLE DVDs;
DROP TABLE Rates;
DROP TABLE Members;


CREATE TABLE Rates
(Rate_Code varchar2(2) NOT NULL,
 Description varchar2(20) NOT NULL,
 Rate numeric(4,2) NOT NULL,
 CONSTRAINT pk_Rates PRIMARY KEY (Rate_Code));
 
CREATE TABLE DVDs
(DVD_Id numeric(10) NOT NULL,
 Title varchar2(40) NOT NULL,
 Description varchar2(100) NOT NULL,
 Release_Year numeric(4) NOT NULL,
 Rate_Code varchar(2) NOT NULL,
 Status varchar2(2) NOT NULL,
 Rent_Status varchar2(2) NOT NULL,
 CONSTRAINT pk_DVD_Id PRIMARY KEY (DVD_Id),
 CONSTRAINT fk_DVD_Rate FOREIGN KEY (Rate_Code) REFERENCES Rates);
 
CREATE TABLE Members
 (Member_Id numeric(10) NOT NULL,
  Name varchar2(40) NOT NULL,
  Email varchar2(40) NOT NULL,
  Street varchar2(40)NOT NULL,
  Town varchar2(40) NOT NULL,
  Contact numeric(15) NOT NULL,
  Status varchar2(2) NOT NULL,
  Register_Date date NOT NULL,
  CONSTRAINT pk_Members_Id PRIMARY KEY (Member_Id));
  
CREATE TABLE Rentals
 (Rental_Id numeric(10) NOT NULL,
  Name varchar2(40) NOT NULL,
  Member_Id numeric(10) NOT NULL,
  Rent_Date Date NOT NULL,
  Due_Date Date NOT NULL,
  CONSTRAINT pk_Rental_Id PRIMARY KEY (Rental_Id),
  CONSTRAINT fk_Member_Id_Rent FOREIGN KEY (Member_Id) REFERENCES Members);
   
CREATE TABLE Transactions
 (Transaction_Id numeric(10) NOT NULL,
  Member_Id numeric(10) NOT NULL,
  Rental_Id numeric(10) NOT NULL,
  Transaction_Type varchar2(20) NOT NULL,
  Transaction_Date Date NOT NULL,
  Transaction_Amount numeric(4,2) NOT NULL,
  CONSTRAINT pk_Transactions_Id PRIMARY KEY (Transaction_Id),
  CONSTRAINT fk_Member_Id_Trans FOREIGN KEY (Member_Id) REFERENCES Members,
  CONSTRAINT fk_Rental_Id_Trans FOREIGN KEY (Rental_ID) REFERENCES Rentals);
    
CREATE TABLE RentedItems
 (Rental_Id numeric(10) NOT NULL,
  DVD_ID numeric(10) NOT NULL,
  CONSTRAINT fk_RentalId_RentedItems FOREIGN KEY (Rental_Id) REFERENCES Rentals,
  CONSTRAINT fk_DVDId_RentedItems FOREIGN KEY (DVD_Id) REFERENCES DVDs);
  
 
 
 