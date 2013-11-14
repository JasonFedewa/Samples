var win = Titanium.UI.currentWindow;

//declare the http client object
var xhr = Titanium.Network.createHTTPClient();  

var data = []; //empty data array
var tblRSS = Titanium.UI.createTableView({
   	height: 366,
	width: 320,
	top: 0,
	left: 0
});
win.add(tblRSS);

//Open up the xml feed
//Hard coded for the moment. I will be adding functionality
//for users to set there own feeds. As well as a search function.
xhr.open('GET','http://pipes.yahoo.com/pipes/pipe.run?_id=cb12e429d64ba6e07fe930bc00095cf1&_render=rss');

//Call the remote feed
xhr.send();

//this method will process the remote data
xhr.onload = function() { 
   var xml = this.responseXML;
   
   //get the item nodelist from our response xml object 
   var items = xml.documentElement.getElementsByTagName("item");

   //loop each item in the xml
   for (var i = 0; i < items.length; i++) {
   	
	    //create a table row
		var row = Titanium.UI.createTableViewRow({
			hasChild: true,
			className: 'rss-row'		
		});
		
		//Title label
		var titleLabel = Titanium.UI.createLabel({
			color: '#ccc',
			text:
			items.item(i).getElementsByTagName("title").item(0).text,
			font: {fontSize: 18, fontWeight: 'bold'},
			textAlign: Ti.UI.TEXT_ALIGNMENT_CENTER,
			left: 0,
			top: 2,
			bottom: 2,
			height: 30,
			width: 280,
			borderColor: '#0000FF',
			borderWidth: 5,
		});
		row.add(titleLabel);
		
		//add the table row to the data[] object
		data.push(row);
   }
   
   //finally, set the data property of the tableView to the data[] object
   tblRSS.data = data;   
};