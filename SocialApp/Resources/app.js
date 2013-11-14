//Athentication java script for twitter
Ti.include('birdhouse.js');

// this sets the background color of the master UIView.
Titanium.UI.setBackgroundColor('#000');
var tabGroup = Titanium.UI.createTabGroup();

//Msg Window and tab
var win2= Titanium.UI.createWindow({  
    title:'Msg',
    backgroundImage: 'images/background.jpg'
});
var tab2 = Titanium.UI.createTab({  
    icon:'KS_nav_ui.png',
    title:'Msg',
    window:win2
});

//App Label
var label = Titanium.UI.createLabel({
    width:  280,
    height: 'auto',
    top: 20,
    left: 20,
    color: '#fff',
    font: {fontSize: 18, fontFamily: 'Helvetica', fontWeight: 'bold'},
    text: 'Chatter Box'
});
win2.add(label);

//Title text field of Msg tab
var txtTitle = Titanium.UI.createTextField({
    width: 160,   
    height: 35,
    left: 80,
    top: 60,
    value: 'Message title...',
    borderStyle: 2,
    backgroundColor: '#fff'
});
win2.add(txtTitle);

//Recipient text field of Msg tab
var txtEmAddress = Titanium.UI.createTextField({
    width: 160,
    height: 35,
    left: 80,
    top: 100,
    value: 'Recipient Email',
    borderStyle: 2,
    backgroundColor: '#fff'
});
win2.add(txtEmAddress);

//Message text field of Msg tab
var txtMessage = Titanium.UI.createTextArea({
    width: 160,
    height: 120,
    left: 80,
    top: 140,
    value: 'Message text...',
    font: {fontSize: 15},
    borderStyle: 2,
    backgroundColor: '#fff'
});
win2.add(txtMessage);

//
//create email
//
function postToEmail() {

    var emailDialog = Titanium.UI.createEmailDialog();
    emailDialog.subject = txtTitle.value;
    emailDialog.toRecipients = txtEmAddress.value;
    emailDialog.messageBody = txtMessage.value;
    
    emailDialog.open();
}

//Adds a button for accessing the postToEmail()
var buttonEmail = Titanium.UI.createButton({
    width:  280,
    height:  35,
    top: 280,
    left: 20,
    title: 'Send Via Email'
});

//Event listener for the email button
buttonEmail.addEventListener('click', function(e){
    postToEmail();
});
win2.add(buttonEmail);

//Nulls the text field so the user does not need to delete the place holder text
txtTitle.addEventListener('click', function(e){
	txtTitle.value = '';
});

//Nulls the text field so the user does not need to delete the place holder text
txtEmAddress.addEventListener('focus', function(e){
	txtEmAddress.value = '';
});

//Nulls the text field so the user does not need to delete the place holder text
txtMessage.addEventListener('focus', function(e){
	txtMessage.value = '';
});

//
//Twitter
//
//create your twitter session and post a tweet
function postToTwitter()
{
	
   var BH = new BirdHouse({
    consumer_key: "t0ytVJI1nc4k5br8Krab7A",
    consumer_secret: "fQ6m2Ygv7b9WhOXoBoXPEfjNciFB6yd1VYvuSbnc",
    callback_url: 'https://twitter.com/JasonFedewa'
   });
   
   if(!BH.authorized){
      BH.authorize();
   }
   else
   {  
   	
       Ti.API.info('Posting: ' + txtMessage.value );
               
    	BH.tweet(txtMessage.value, function(e) {
  		var alertMsg = Ti.UI.createAlertDialog();
 		   if (e===true) {
   		     alertMsg.message = 'Sent!';
  		   } else {
   		     alertMsg.message = 'Failed!';
   		     Ti.API.info(e.Object.toString);
   		     Ti.API.info(e.toString);
			BH.toString();
  		   }
  	    alertMsg.show();
		});

   }
}

var buttonTwitter = Titanium.UI.createButton({
    width:  280,
    height:  35,
    top: 320,
    left: 20,
    title: 'Send Via Twitter'
});
buttonTwitter.addEventListener('click', function(e){
    postToTwitter();

});
win2.add(buttonTwitter);

//RSS window and tab
var win1 = Titanium.UI.createWindow({
	title: 'RSS',
	backgroundImage: 'images/background.jpg',
	url: 'rssfeed.js'
});
var tab1 = Titanium.UI.createTab({  
    icon:'KS_nav_views.png',
    title:'RSS',
    window:win1
});

//Add an options menu that allows the user to change the RSS feed, also allows user
//To save and load previous choices.

//Add tabs to the group
tabGroup.addTab(tab1);  
tabGroup.addTab(tab2); 

// open tab group
tabGroup.open();
