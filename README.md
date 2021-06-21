<p align="center">
    <img src="src/MRCase.UI/img/appicon.png" style="max-width:100%;" height="150"  />
</p>

# Mobiroller Case
This Project features users to import their specific json data(important events) and view them after logging in to application.  
  
<b>UI: </b> https://mrcase.alims.online/  
<b>API: </b> https://mrcaseapi.alims.online/swagger

<b>Demo User</b>  
<b>Username</b>: demoUser  
<b>Password</b>: Password1.

### Supported Languages
- Turkish
- Italian

### Data Format
#### Turkish Example
```json
[
    {
        "ID":1,
        "dc_Zaman":"1 Ocak",
        "dc_Kategori":"Olay",
        "dc_Olay":"MÖ 45 - Jülyen takvimi ilk kez kullanılmaya başlandı. 
            16. yüzyıla kadar kullanıldıktan sonra yerini Gregoryen takvime bırakacaktır."
    }
]
```

#### Italian Example
```json
[
    {
        "ID":1,
        "dc_Orario":"1º gennaio",
        "dc_Categoria":"Eventi",
        "dc_Evento":"4713 a.C. – L'astronomo Joseph Justus Scaliger considera questo giorno 
            come il giorno giuliano zero."
    }
]
```  
### Used Technologies
<b>Backend:</b> ASP.NET Core 3.1, EF Core, MsSQL<br>
<b>Frontend:</b> HTML, CSS, Javascript, JQuery, Bootstrap 4

### What is in this project?
Authentication, Localization, Exception Handler, In-Memory Cache, AutoMapper, Multi-Tenancy, Validation with ActionFilter, Pagination
***

### How To Use?
After Clone/Download project, execute command `EntityFrameworkCore\Update-Database` in Package Manager Console 
<hr>
<br>
<p align="center"><b>Register/Login</b></p>
<img src='images/login.png' width='100%'>  
<hr>
<br>
<p align="center"><b>Import Data by your Language. Other languages will not be imported. After import you can change pages to see all data.</b></p>
 <img src='images/index.png' width='100%'>  
<hr>
<br>
<p align="center"><b>That's all. OpenApi Documentation</b></p>
<img src='images/swagger.png' width='100%'>  

