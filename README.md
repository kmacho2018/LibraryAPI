# LibraryAPI

Description: LibraryAPI Project for Team Lead Vacant

#### Get Help
http://localhost:52491/Help
#
#

#### List of Books
### ``` http://localhost:52491/api/Book ```
#
#### Retreive Book By Id
### ``` http://localhost:52491/api/Book/{BookId} ```
#
#### Read a Book
### ``` http://localhost:52491/api/Book/{BookId}/page/{PageNumber}/{Format: plain|html} ```
#

#### For testing the services

* GET Books
###  Samples:
### ``` http://localhost:52491/api/Book```
#

* GET Book By Id
###  Samples:
###  ``` http://localhost:52491/api/Book/1```
#

#
* Read a Book 
###  Samples:
###  ``` http://localhost:52491/api/Book/1/page/1/plain```
###  ``` http://localhost:52491/api/Book/1/page/1/html```
#

* For run Unit test, please execute the command:
###  ``` Open Visual Studio 2017 Go to Menu - > Test -> Run -> All Tests``


## Instalation

1. Clone the project

	``` git clone https://github.com/kmacho2018/LibraryAPI.git```

2. Install all the dependencies

	``` SQL Server Express 2017 ```
	#
	``` Microsoft Visual Studio 2017 Enterprise Edition ```
	#
	``` Run scriptdb.sql on Microsoft SQL Server DataBase```
	#
	``` Verify ..\LibraryAPI\LibraryAPI.Web\Web.config file and check the connectionString ```
	``` Verify ..\LibraryAPI\LibraryAPI.Web.Tests\App.config file and check the connectionString ```


3. Start the project

	```Open Visual Studio  -> Run```

## Thats it

yes, the project's ready!.

## Credits
Created by Juan Camacho  

## License

	Copyright 2018 Juan Camacho
	
	Licensed under the Apache License, Version 2.0 (the "License");
	you may not use this file except in compliance with the License.
	You may obtain a copy of the License at
	
	   http://www.apache.org/licenses/LICENSE-2.0
	
	Unless required by applicable law or agreed to in writing, software
	distributed under the License is distributed on an "AS IS" BASIS,
	WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
	See the License for the specific language governing permissions and
	limitations under the License.
