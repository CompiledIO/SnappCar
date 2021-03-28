# SnappCar

Solution consists of an API and Console App.

I am not sure if I factored in too much setup in my build time but I did not even get to send and process a booking via the queue. (Which I did look forward to)
What I done in setup is just create a Web Api Project and a Console Application and get RabbitMQ running on my system. the rest I done all within the given timeframe.

The project has one controller to request a booking quote as I call it and verify that the vehicle is available.

Setup .Net 5 to run the application and point it to a database and run EntityFrameworkCore\Update-Database to create the DB.
