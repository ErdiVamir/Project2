# Project2



### Expected Result

---

#### 1.Excel file generated.
Tab1 named = Category2

content:


|testKey	|CategoryType	|TestType	|LastName	|Result|
|---------------|---------------|---------------|---------------|------|
|Test-2001	|Category2	|Sanity		|Gee		|PASS  |
|Test-2002	|Category2	|Sanity		|Progressive Sports|FAIL|


Tab 2 named = Results

content:


|Category	|testKey	|Result		|
|---------------|---------------|---------------|
|Category1	|Test-1001	|PASS		|
|Category1	|Test-1002	|PASS		|
|Category2	|Test-2001	|PASS		|
|Category2	|Test-2002	|FAIL		|

---

#### 2.Two Json files generated, category based

1st file content:

{"tests":[{"status": PASS, "testKey": "Test-1001"},
{"status": PASS, "testKey": "Test-1002"}
]}

2nd file content:

{"tests":[{"status": PASS, "testKey": "Test-2001"},
{"status": FAIL, "testKey": "Test-2001"}
]}