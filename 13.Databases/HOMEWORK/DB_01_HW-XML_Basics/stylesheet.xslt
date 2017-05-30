<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <head>
        <link href="styles.css" rel="stylesheet" />
      </head>
      <body>
        <h1>XML Basics</h1>
        <h1>Students</h1>
        <table>
          <thead>
            <tr>
              <th>Name</th>
              <th>Gender</th>
              <th>Birth date</th>
              <th>Phone</th>
              <th>E-mail</th>
              <th>Course</th>
              <th>Specialty</th>
              <th>Faculty number</th>
              <th>Exams</th>
              <th>Enrollment</th>
              <th>Teacher's Endorsements</th>
            </tr>
          </thead>
          <tbody>
            <xsl:for-each select="https://mysite.com/my-awesome-xmlnamespace/student">
              <tr>
                <td>
                  <xsl:value-of select="name" />
                </td>
                <td>
                  <xsl:value-of select="sex" />
                </td>
                <td>
                  <xsl:value-of select="birthDate" />
                </td>
                <td>
                  <xsl:value-of select="phone" />
                </td>
                <td>
                  <xsl:value-of select="email" />
                </td>
                <td>
                  <xsl:value-of select="course" />
                </td>
                <td>
                  <xsl:value-of select="specialty" />
                </td>
                <td>
                  <xsl:value-of select="facultyNumber" />
                </td>
                <td>
                  <xsl:for-each select="exams/exam">
                    <div>
                      <strong>
                        <xsl:value-of select="examName"/>
                      </strong> /
                      tutor: <xsl:value-of select="tutor"/> /
                      score: <xsl:value-of select="score"/>
                    </div>
                  </xsl:for-each>
                </td>
                <td>
                  <xsl:for-each select="enrollment">
                    <div>
                      Date: <xsl:value-of select="date"/>
                      Exam Score: <xsl:value-of select="examScore"/>
                    </div>
                  </xsl:for-each>
                </td>
                <td>
                  <xsl:value-of select="teacherEndorsements" />
                </td>
              </tr>
            </xsl:for-each>
          </tbody>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>