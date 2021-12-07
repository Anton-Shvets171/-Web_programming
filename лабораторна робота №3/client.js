$(document).ready(function(){
    function getUsers(){
    $.get('/getusers',function(data){
       createTable('conteiner', data);
        })
    }

    function createTable(container, data) {
        const mas = JSON.parse(data);
        const table = document.getElementById(container);

        const link = document.createElement('link');
        link.rel = 'stylesheet';
        link.href = 'style.css';
        document.head.appendChild(link);
        
        table.classList.add("./style");

        const thead = $('<thead>').appendTo(table);
        const tr = $('<tr>').appendTo(thead);
        for(let key in mas[0]){
        
            const th = $('<th>').appendTo(tr);
            $(th).text(key);          
            console.log(key);
        }

        const tbody = $('<tbody>').appendTo(table);
        console.log(mas.length);
        for(let i = 0; i < mas.length; i++){
          const row = $("<tr>");
          console.log(row);
          for(let key in mas[i]){
            const td = $('<td>').appendTo(row);
            $(td).text(mas[i][key]);
            console.log(mas[i][key]);
          }
          row.appendTo(tbody);
        }
    }
    getUsers();
})