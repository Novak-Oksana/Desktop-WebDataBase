var personTable = document.getElementById('persons').getElementsByTagName('tbody')[0];
function load() {
	personTable.innerHTML = localStorage.getItem('Myperson');
}
function save(){
	localStorage.setItem('Myperson', personTable.innerHTML);
}
function addStart() {
	add(0);
}

function addEnd() {
	add(personTable.rows.length);
}

function addMid() {
	add(personTable.rows.length / 2);
}

function delStart() {
	var s = "";
	var arr = personTable.innerHTML.split("<tr>");
	for (var i = 2; i < arr.length; i++) {
	s = s+"<tr>"+arr[i];
	}
	personTable.innerHTML = s;
}

function delEnd() {
	var s = "";
	var arr = personTable.innerHTML.split("<tr>");
	for (var i = 1; i < arr.length - 1; i++) {
		s = s+"<tr>"+arr[i];
	}
	personTable.innerHTML = s;
}

function delMid() {
	pos = Math.floor(personTable.rows.length / 2);
	var s = "";
	var arr = personTable.innerHTML.split("<tr>");
	for (var i = 1; i < arr.length; i++) {
		if(i == pos + 1)
		{
			continue;
		}
		s = s+"<tr>"+arr[i];
	}
	personTable.innerHTML = s;
}

function add(pos) {
	var id = document.getElementById('id').value;
	var fn = document.getElementById('fn').value;
	var ln = document.getElementById('ln').value;
	var age = document.getElementById('age').value;
	
	var str = "<tr><td>" + id + "</td><td>" + fn + "</td><td>"+ ln + "</td><td>"+ age +"</td></tr>";
	
	if(pos == 0)
	{
		personTable.innerHTML = str + personTable.innerHTML;
	}
	else if(pos == personTable.rows.length)
		{
			personTable.innerHTML = personTable.innerHTML + str;
		}
		else if(pos == personTable.rows.length / 2)
			{
				pos = Math.floor(pos);
				var s = "";
				var arr = personTable.innerHTML.split("<tr>");
				for (var i = 1; i < arr.length; i++) {
					if(i == pos + 1)
					{
						s += str;
					}
					s = s+"<tr>"+arr[i];
				}
				personTable.innerHTML = s;
			}	
}

function clearTable() {
	personTable.innerHTML = "";
}