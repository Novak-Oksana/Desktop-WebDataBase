 var table;
      window.onload = function(){
        table = document.getElementById('persons');
      }
      function addStart(){
        
		var okRow = table.insertRow(0);
	   okRow.innerHTML = '<tr> <td width="25%">'+id.value+'</td> <td width="25%">'+fn.value+'</td> <td width="25%">'+ln.value+'</td> <td width="25%">'+age.value+'</td></tr>';			
      }
	 
	  function addMid(){
	  var okRow = table.insertRow(table.rows.length/2);
	  okRow.innerHTML = '<tr> <td width="25%">'+id.value+'</td> <td width="25%">'+fn.value+'</td> <td width="25%">'+ln.value+'</td> <td width="25%">'+age.value+'</td></tr>';		
      }
	  
      function addEnd(){
        var okRow = table.insertRow(length-1);
	    okRow.innerHTML = '<tr> <td width="25%">'+id.value+'</td> <td width="25%">'+fn.value+'</td> <td width="25%">'+ln.value+'</td> <td width="25%">'+age.value+'</td></tr>';			
      }	  
	  
	  
	function delEnd()
	{
		if (table.rows.length > 0) table.deleteRow(table.rows.length - 1);
	}
	function delStart()
	{
		if (table.rows.length > 0) table.deleteRow(0);
	}
	function delMid()
	{
		if (table.rows.length > 0) table.deleteRow(table.rows.length/2);
	}	
	
	function clearTable()
	{	
		 table.innerHTML = "";				
	}
	
	function saveXml()
  {      
    var xmlString = '<Persons>';
    
    for (var i = 0; i < table.rows.length; i++)
    {
      	xmlString += "<Person>";
	    if ( table.rows[i].cells[0] )
	    {
	      xmlString += "<Id>"+table.rows[i].cells[0].textContent+"</Id>";
	    }
	    if ( table.rows[i].cells[1] )
	    {
	      xmlString += "<FirstName>"+table.rows[i].cells[1].textContent+"</FirstName>";
	    }
	    if ( table.rows[i].cells[2] )
	    {
	      xmlString += "<LastName>"+table.rows[i].cells[2].textContent+"</LastName>";
	    }
	    if ( table.rows[i].cells[3] )
	    {
	      xmlString += "<Age>" + table.rows[i].cells[3].textContent+ "</Age>";
	    }
      	xmlString += "</Person>";
    }
    xmlString += "</Persons>";
    localStorage.setItem("personXML", xmlString);      
    console.log(xmlString);
  }



	function loadXml()
	{
		var xmlText = localStorage.getItem("personXML");
		var xsltText =
		'<xsl:stylesheet version="1.0" ' + //показывает что этот документ €вл€етс€ документом типа УXSLT style sheetФ 
		    'xmlns:xsl="http://www.w3.org/1999/XSL/Transform" ' +
		    'xmlns="http://www.w3.org/TR/xhtml1/strict"> ' +
            '<xsl:template match="/"> ' +// используетс€ дл€ построени€ шаблонов преобразовани€ 
            '<table  border="1"> ' +
				'<thead> ' +
				'<tr>' +
					'<th>Id</th>' +
					'<th>First Name </th>' +
					'<th>Last Name </th>' +
					'<th>Age</th>' +
				'</tr>' +
				'</thead >' +
				'<tbody id="tableBody"> ' +
				'<xsl:for-each select="persons/person"> ' + //используетс€ дл€ перебора всех элементов, которые подход€т условию выборки
				  '<tr> ' +
					'<td> <xsl:value-of select="id"/> </td> ' +
					'<td> <xsl:value-of select="firstName"/> </td> ' +
					'<td> <xsl:value-of select="lastName"/> </td> ' +
					'<td> <xsl:value-of select="age"/> </td> ' +
				  '</tr> ' +
					'</xsl:for-each>  ' +
				'</tbody>' +
			'</table> ' +
			'</xsl:template> ' +
        '</xsl:stylesheet> ';
        var xmlDoc = new DOMParser().parseFromString(xmlText, "text/xml");
        var xslDoc = new DOMParser().parseFromString(xsltText, "text/xml");
      //  debugger;
        if (window.ActiveXObject ) {
            var ex = xmlDoc.transformNode(xslDoc);//таблица стилей XSL примен€етс€ к XML документу
            document.getElementById("tableDiv").innerHTML = ex;
        }
        // code for Chrome, Firefox, Opera, etc.
        else if (document.implementation && document.implementation.createDocument) {
            var xsltProcessor = new XSLTProcessor();
            xsltProcessor.importStylesheet(xslDoc);
            resultDocument = xsltProcessor.transformToFragment(xmlDoc, document);
            document.getElementById("tableDiv").innerHTML = "";
            document.getElementById("tableDiv").appendChild(resultDocument);
        }
        //xmlDoc.loadXML(xmlText);
        table = document.getElementById('persons');        

	//	document.getElementById("XMLResult").innerHTML = xmlText;
	}
		
	Storage.prototype.setObj = function(key, obj) {
    return this.setItem(key, JSON.stringify(obj))
	}
	Storage.prototype.getObj = function(key) {
		return JSON.parse(this.getItem(key))
	}