<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
      <table class="table table-responsive align-items-center mb-0">
        <thead>
          <tr>
            <th class="text-uppercase text-secondary text-xxs font-weight-bolder opacity-7">Customer</th>
            <th class="text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2">phone</th>
            <th class="text-center text-uppercase text-secondary text-xxs font-weight-bolder opacity-7">address</th>
          </tr>
        </thead>
        <tbody>
          <xsl:for-each select="users/user">
            <tr>
              <td>
                <div class="d-flex px-2 py-1">
                  <div>
                    <p class="info"></p>
                  </div>
                  <div class="d-flex flex-column justify-content-center">
                    <h6 class="mb-0 text-sm">
                      <xsl:value-of select="name"/>
                    </h6>
                    <p class="text-xs text-secondary mb-0">
                      <xsl:value-of select="email"/>
                    </p>
                  </div>
                </div>
              </td>
              <td>
                <p class="text-xs font-weight-bold mb-0">
                  <xsl:value-of select="phone"/>
                </p>
              </td>
              <td class="align-middle text-center text-sm">
                <span class="badge badge-sm bg-gradient-info">
                  <xsl:value-of select="address"/>
                </span>
              </td>
            </tr>
        </xsl:for-each>
        </tbody>
      </table>
  </xsl:template>

 

</xsl:stylesheet>