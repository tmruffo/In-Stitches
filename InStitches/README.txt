Name: Toni Ruffo
Application: In Stitches

Description: 
		This application is to be used as a tool for people who knit and/or crochet. 
	    It provides two main features: 
			- An inventory tracker for knitting needles and crochet hooks.
			- A gauge measure for unmarked needles and hooks.

Project Goals: 
		As a knitter and crocheter, I often find that I am acquiring hooks and needles that do not have the size marked on it. 
		The packaging may have this information, but it is easy to lose the packaging or separate it from the needles/hook, so the information is then useless. 
		The gauge measure feature of this application will allow users to determine the size of their hooks and needles by holding the instrument up to the screen and measuring it against a chart.
		This will eliminate the need for users to purchase new hooks and needles if they do not know which needles/hooks they already own match the required size.

How to Run:
		This application can be run both from Visual Studio and from a Click-Once application.
		The solution can be opened in Visual Studio (I used VS 2013 Community Edition) and can be run directly.
		In addition, in the main project folder, there is an executable "setup.exe", which will install the application and run it.
		
Instructions:
		On the Inventory tab, the user can switch between knitting and crochet using tab controls.
		To increment a cell, the user just needs to click the desired cell and the number will increase by 1.
		On the Gauge tab, the user can switch between knitting and crochet using tab controls, much like in the Inventory tab.
		To find the gauge of a hook or needle, the user can hold their instrument up to the screen.
		Find the closest matching square (the size of the needle/hook without the square being larger). That is the size of the needle/hook.
		
Future Plans:
		- Hook up a database/account system so users can save their inventory information after the application is closed.
		- Allow users to delete hooks/needles from the Inventory system.
		- Port to mobile/tablet
		- Lock control borders so the application resizes properly.
		- Perhaps change the colors on the gauge tab--some of the yellows/greens can be difficult to see.