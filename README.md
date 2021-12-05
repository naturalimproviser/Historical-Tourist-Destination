# Historical-Tourist-Destination
HIstorical Tourist Destination Final project

We have created a webapp for anyone looking to explore the ancient wonders of the world. 
By succesfully complining JSON files from two dirrfent APIs our webapp aims to provide it's user a detaild overview of some of 
the most famous Historical Tourism destinations around the globe. 

Our application provides has the following Unique features - 
- Detects and displays the historical tourism destinantions in a country.
- Provides a short description of the destination, signfying it's cultural importance.
- provides the area in sq miles, to help with planning a hassle free and memorable travel.
- Provides the geographical cordinates of the location
- Displays the average temprature at the location.
- provide a one stop solution to the visitor, helping him/her plan a seamless vacation. 

The JSON files uses open source data from several website, while also displaying the wikipedia page for providing external information to curious user. 

Functionality
(When)Scenario 1 -
Search for a specific country name in the web app
Dependency - The specified country has a unesco heritage site (historical monument)

(Then) Result - 
The search matches the country name with the conutries in the data feed and displays a list of results in a tablular format
The search shows all the historical monumnets in that specific country with a short description, geographical cordinates of the location, and the averrage temprature of the location.

(When)Scenario 2 -
Search for a specific country name in the web app
Dependency - The specified country has a unesco heritage site (historical monument)

(Then) Result - 
The search matches the country name with the conutries in the second data feed which is the weather API and generates a max-min temprature range, further it displays an average temprature of the location. 

Assumptions - 
The required country does have a Unesco heritage site.
The required country does have a valid city and location which matches with the data acquired through the web API.

Data Feeds 
Unesco Heritage sites - https://whc.unesco.org/en/list/
Weather data - https://www.weatherbit.io

Our Team - 
Deepak Narang, 
Sehar Nagpal, 
Jayanth Chaudhary Bandi

Weekly Meeting
Sunday at 4-7 PM on Teams
