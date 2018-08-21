$(function () {

	//
	var InputTextBox = $("#textboxinput");
	var OutputTextBox = $("#textboxoutput");
	var API = $("#API");
	const apiURL = "https://api.funtranslations.com/translate/";
	const databaseURL = "http://localhost:53725/home/add";

	//event for submit button
	var SubmitButton = $("#submit");
	SubmitButton.on("click", function (e) {
		translateText();
		
	});

	//event for reset button
	var ResetButton = $("#reset");
	ResetButton.on("click", function (e) {
		InputTextBox.val("");
		OutputTextBox.val(""); 
	});


	//ajax function for translate request
	function translateText() {
		var text = InputTextBox.val();
		console.log("Our text:" + text)
		$.ajax({
			url: (apiURL + API.val() + '?text=' + text),
			type: "POST",
			
		}).done(function (data) {
			console.log("Get new translate!");
			OutputTextBox.val(data.contents.translated);
			AddToDatabase(data.contents.translated)
		}).fail(function (error) {
			console.log("Translate - error!");
			console.log(error.status, error.statusText);
		})
	}
	
	//ajax function for send log into database
	function AddToDatabase(data) {
		
		var newLog = {
			InputText: InputTextBox.val(),
			OutputText: data,
			APIText: API.val()
		};
		$.ajax({
			url: databaseURL,
			type: "POST",
			data: newLog

		}).done(function (data) {
			console.log(data);
			console.log("Added new log into database!");
		}).fail(function (error) {
			console.log("Send log - error!");
			console.log(error.status, error.statusText);
		})
	}
})

	