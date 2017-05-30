###### [My Telerik Academy Courses](https://github.com/nikolovdeyan/TelerikAcademy) 
---

## XML Basics
### _Homework_

---

##### 01. What does the XML language represent? What is it used for? 
XML (Extensible Markup Language) is a markup language derived from SGML. It defines a set of rules for encoding documents in a format that is readable to both humans and machines but is software- and harware-independent. XML is self-descriptive by design. XML does not use predefined tags and is expendable (most XML applications work as expected even when new data is added). 

Applications of XML: XML is used to store and transfer data. Many IT systems use XML or formats derived from XML. 
 - Simplifies data sharing
 - Simplifies data transfer
 - Simplifies data availability. Separation of data and presentation
 - Plain text format. Independent of software and hardware. Readable for both humans and machines

XML documents form a tree structure starting with the root element:
![XML Tree Scheme](./resources/xml-tree-structure.gif)
*Image: www.w3schools.com*

---

##### 02. Create XML document `students.xml`, which contains structured description of students.
 - For each student you should enter information for his name, sex, birth date, phone, email, course, specialty, faculty number and a list of taken exams (exam name, tutor, score).
 
> Solution: [students.xml](students.xml)
 
---

##### 03. What do namespaces represent in an XML document? What are they used for? 

> Namespaces are used for providing uniquely named elements and attributes in an XML document. The namespace name is added as a prefix to the XML element, but to use the prefix namespace it must be defined first. That can be done vie the `xmlns` attribute in the start tag of an element:

```xml
<root>

<h:table xmlns:h="http://www.w3.org/TR/html4/">
  <h:tr>
    <h:td>Apples</h:td>
    <h:td>Bananas</h:td>
  </h:tr>
</h:table>

<f:table xmlns:f="https://www.w3schools.com/furniture">
  <f:name>African Coffee Table</f:name>
  <f:width>80</f:width>
  <f:length>120</f:length>
</f:table>

</root> 
```
> Namespace can be defined also for all the child elements of an element as follows:

```xml
<table xmlns="http://www.w3.org/TR/html4/">
  <tr>
    <td>Apples</td>
    <td>Bananas</td>
  </tr>
</table> 
```


---

##### 04. Explore http://en.wikipedia.org/wiki/Uniform_Resource_Identifier to learn more about URI, URN and URL definitions.

> An Uniform Resource Identifier is a string of characters used to identify a resource. The most common form of URI is the Uniform Resource Locator (URL), or web address. Another form is the Uniform Resource Name (URN), which is designed to complement the URLs by providing a namespacing mechanism.

> A URN can be compared to a person's name, a URL can be compared to an address. URL provides a method for locating an item identified by a URN. A URL is simply a URI that points to a resource over a network. 

---

##### 05. Add default namespace for students "`urn:students`".

> Solution: [students-w-namespace.xml](students-w-namespace.xml)

---

##### 06. Create XSD Schema for `students.xml` document.
 - Add new elements in the schema: information for enrollment (date and exam score) and teacher's endorsements.
 
 > Solution: [students-w-namespace.xsd](students-w-namespace.xsd)
 
 ---
 
##### 07. Write an XSL stylesheet to visualize the students as HTML.
 - Test it in your favourite browser.
 
#### Resources:
 - [XML -- w3.org](https://www.w3.org/XML/)
 - [XML Tutorial -- w3schools.com](https://www.w3schools.com/xml/)
 - [XML -- wikipedia.org](https://en.wikipedia.org/wiki/XML)
 - [XML Namespace -- wikipedia.org](https://en.wikipedia.org/wiki/XML_namespace)
 - [Uniform Resource Identifier -- wikipedia.org](https://en.wikipedia.org/wiki/Uniform_Resource_Identifier)
 - [Uniform Resource Name](https://en.wikipedia.org/wiki/Uniform_Resource_Name)
 - [Uniform Resource Locator](https://en.wikipedia.org/wiki/URL)
 - [Understanding Namespaces in XML](https://msdn.microsoft.com/en-us/library/aa468565.aspx)
 - [XML Schema Tutorial -- w3schools.com](https://www.w3schools.com/xml/schema_intro.asp)
