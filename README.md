# StockPortfolioTracker
My AAS Degree Capstone Project


Analysis of Problem

 	A friend who has a small stock portfolio that he tracks using pen and paper.  He tracks each stock on an individual sheet were
purchases, sales, commissions, and monthly prices are recorded.  He evaluates the potential Return On Investment (ROI) once a month.
When his portfolio was small the amount of time spent tracking was minimal, though as the portfolio and number of shares increases the
time he spends tracking the portfolio has also increased.  He also has some line charts that his friend provided which graphically shows
the fluctuation of a stock’s price.  He can only get these charts every few months and wishes he could have chart when he updates his
stock prices.
	Upon further discussions, it was revealed that he uses multiple local brokers to purchase and sell his stocks and has even
purchased the same stock from different brokers.  


Specifications
General Overview

	The program will allow the user to enter his purchases of stocks, update the current price of each stock, and the sale of stocks. 
Additional information that the user will enter is broker information. As this information is entered it must be stored in a relational
database. At the same time, any changes to the stock portfolio will cause the individual stock and entire portfolio valuation to be
recalculated.  This application will be a Windows Form application written in C#.  It will store all information in a SQL database that 
is accessed using Dapper, a third-party micro ORM. 
