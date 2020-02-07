Functional Requirements
-	The TODO HTTP API lets a client create, read, update and delete to-do tasks.
-	A task has a title, description, importance (low, normal - default, high), optional due date and can be completed or active.
-	Multiple tasks can be deleted at once.
-	Completed tasks should be soft-deleted.
-	Task can exist within a list(s) only. List is a container of tasks. Client may use lists to semantically organized/categorize tasks.
-	There are two types of lists exist in the application: smart and custom.
•	Smart Lists are lists that exist within application and cannot be deleted by the client. The following smart list should preexist within application:
o	All tasks (includes all tasks created by the user)
o	Planned tasks (which have a due date set)
o	Important tasks (which have “Important” flag set)
o	Today’s tasks (due date = today)
•	Custom Lists – created by clients. Can be deleted, updated by the client.
-	A single task can be associated with multiple smart lists (at least one) and single custom list only.
-	List should have a setting to not return completed tasks.
-	It should be possible to rename existing lists (except for smart ones)
-	It should be possible to configure default sort by (Ascending/Descending) for any type of list by:
o	Importance (low => normal => high)
o	Due date
o	Completed flag
o	Alphabetically
o	Creation date
-	Configured sort order should applied to any query for tasks within list.
-	It should be possible to search for tasks by name across all lists

Non-Functional Requirements
-	Please document the API with the OpenAPI.
-	Please create private project in Azure DevOps with git repo and do all the development there.
-	It should be possible to compile code right after cloning the repo.
-	The solution must have unit tests. All test should pass. Make sure that test have any sense.
-	Detailed instruction on how to set up a solution including dependencies (in case of any) and how to make it up and running should be provided as a markdown readme file in the root of repo.
-	.net core 3.1 and c# 8.0 will be a plus.
-	When implementing HTTP API try to conform with the RMM level 2
