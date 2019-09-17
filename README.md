# Betting-App
A betting web application made in .NET Core and ReactJS.

The frontend consists of the Offer and Account screens, the Offer used for betting while Account is used for transaction and ticket history along with balance payments.

The backend is separated into the Data, Domain and Web layers. Data contains the database entity models, context and enums, Domain contains the repositories used for specific operations needed to implement the business logic, while the Web layer has controllers used as endpoints.

There is only one user, as the application is imagined as a betting machine and requires no users, but the database entity was implemented thinking of possible future enhancements. 
Types are linked to a specific sport(actually to a specific match) by Pair database entries with the selected match and betType.
Matches update using the MockResultRepository, whose UpdateMatches() function is triggered by HttpRequest when the client app starts. Team scores are assigned randomly, with max values differing across sports, the pairs set to correct or false, and tickets either assigned a lost or a won status.
The Match seeds are set for the 19th, 20th and 21st of September, along with two on September 10th to demonstrate that the MockResultRepository actually works.

Hope you like it!