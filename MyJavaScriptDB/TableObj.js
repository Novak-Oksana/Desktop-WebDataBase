var persons = [];

	function Person(id, fn, ln, age) {
		this.id = id;
		this.fn = fn;
		this.ln = ln;
		this.age = age;
		return this;
	}

	function getPerson() {
		var id = document.getElementById('id').value;
		var fn = document.getElementById('fn').value;
		var ln = document.getElementById('ln').value;
		var age = document.getElementById('age').value;
		return new Person(id,fn,ln,age);
	}
	
	function addStart(){
	    persons.unshift(getPerson());
		PrintPersons();
	}
	
	function addMid(){
	    persons.splice(persons.length / 2, 0, getPerson());
		PrintPersons();
	}

	function addEnd(){
	    persons.push(getPerson());
		PrintPersons();
	}
	
	function delStart(){
	    persons.shift();
		PrintPersons();
	}
	
	function delMid(){
	   persons.splice(Math.ceil(persons.length / 2-1), 1);
		PrintPersons();
	}
	
	function delEnd(){
	    persons.pop();
		PrintPersons();
	}
	
	function clearTable(){
	   persons = [];
	}
	
	//сериализация объекта persons
	function save(){
	   localStorage.setItem("Mypersons", JSON.stringify(persons));
	}
	
	function load(){
	   persons = JSON.parse(localStorage.getItem("Mypersons"));
	   PrintPersons();
	}

	
	function PrintPersons() {
	    		var tableRef = document.getElementById('tablePerson').getElementsByTagName('tbody')[0];
		tableRef.innerHTML = "";
	
		persons.forEach(function(item) {
			var tableRef = document.getElementById('tablePerson').getElementsByTagName('tbody')[0];
			var newRow   = tableRef.insertRow(tableRef.rows.length);
		    var cellId  = newRow.insertCell(0);
			var cellFn = newRow.insertCell(1);
			var cellLn = newRow.insertCell(2);
			var cellAge = newRow.insertCell(3);
			cellId.appendChild(document.createTextNode(item.id));
			cellFn.appendChild(document.createTextNode(item.fn));
			cellLn.appendChild(document.createTextNode(item.ln));
			cellAge.appendChild(document.createTextNode(item.age));
		});
	}
	
	
	
	
	
	