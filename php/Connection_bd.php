<?php
try
{
   $connector = new PDO('mysql:host=mariadb;dbname=ERP;charset=utf8' , 'root', '123');
}
catch (PDOException $e)
{
   die('Erreur : ' . $e->getMessage());
}



$req = $connector->query('SELECT * FROM t_client ORDER BY cliLastName ASC ');
$result = $req->fetchALL(PDO::FETCH_ASSOC);


foreach ($result as $row){
	
	echo 
	
	$row ["cliName"].
		
	$row["cliLastName"].
	
	$row["cliCompanyName"].
		
	$row["cliAddress"].
		
	$row["cliCity"].
	
	$row["cliCounty"].
		
	$row["cliState"].
		
	$row["cliZip"].
		
	$row["cliPhone1"].
	
	$row["cliPhone2"].
		
	$row["cliEmail"].
		
	$row["cliWeb"].
		
	$row["cliUsserName"];
	
	
	echo "<br>";
	
}





?>