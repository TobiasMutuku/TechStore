<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
	<xsl:output method="html" indent="yes"/>

	<xsl:template match="products">
		<html>
			<head>
				<link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css" rel="stylesheet" />
				<style>
					body {
					font-family: Arial, sans-serif;
					background-color: #f0f0f0;
					margin: 0;
					padding: 0;
					}

					.container {
					max-width: 1200px;
					margin: 0 auto;
					padding: 20px;
					}

					.content {
					display: flex;
					flex-wrap: wrap;
					gap: 20px;
					}

					.box {
					width:330px;
					padding: 5px;
					background-color: #ffffff;
					border: 1px solid #ddd;
					border-radius: 5px;
					box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
					text-align: center;
					}

					.box h3 {
					margin-top: 0;
					font-size: 16px;
					color: #333;
					}

					.box img {
					border-radius: 5px;
					max-width: 200px;
					max-height: 200px;
					}

					.box p {
					margin: 10px 0;
					font-size: 14px;
					color: #777;
					}

					.box a {
					display: inline-block;
					padding: 8px 15px;
					background-color: #ff652f;
					color: #fff;
					text-decoration: none;
					border-radius: 5px;
					}

					.box a i {
					margin-right: 5px;
					}

					.description-full {
					display: none;
					}

					.see-more {
					color: #ff652f;
					text-decoration: underline;
					cursor: pointer;
					}

					.see-less {
					color: #ff652f;
					text-decoration: underline;
					cursor: pointer;
					}
				</style>
				<script>
					function toggleDescription(elementId) {
					var element = document.getElementById(elementId);
					if (element.style.display === 'none') {
					element.style.display = 'block';
					} else {
					element.style.display = 'none';
					}
					}
					function expandDescription(elementId) {
					var summaryElement = document.getElementById('summary-' + elementId);
					var fullElement = document.getElementById('full-' + elementId);
					summaryElement.style.display = 'none';
					fullElement.style.display = 'block';
					}
					function collapseDescription(elementId) {
					var summaryElement = document.getElementById('summary-' + elementId);
					var fullElement = document.getElementById('full-' + elementId);
					summaryElement.style.display = 'block';
					fullElement.style.display = 'none';
					}
				</script>
			</head>
			<body>
				<div class="container">
					<div class="content">
						<xsl:for-each select="product">
							<div class="box">
								<h3>
									<xsl:value-of select="product_name"/>
								</h3>
								<img src="{product_image}" alt="{product_name}"/>
								<p>
									RM <xsl:value-of select="format-number(product_price,'0.00')" />
								</p>
								<p class="description-summary" id="summary-desc{position()}">
									<xsl:value-of select="substring(product_description, 1, 30)"/>....
									<xsl:if test="string-length(product_description) &gt; 30">
										<span class="see-more" onclick="expandDescription('desc{position()}')">See More</span>
									</xsl:if>
								</p>
								<p class="description-full" id="full-desc{position()}">
									<xsl:value-of select="product_description"/>
									<span class="see-less" onclick="collapseDescription('desc{position()}')">See Less</span>
								</p>
								<xsl:choose>
								<xsl:when test="product_quantity &gt; 0">
									<a href="addToCart.aspx?product_id={Id}">
										Add to Cart <i class="fas fa-shopping-cart"></i>
									</a>
								</xsl:when>
								<xsl:when test="product_quantity &lt;= 0">
									<p>Out of Stock</p>
								</xsl:when>
							</xsl:choose>

							</div>
						</xsl:for-each>
					</div>
				</div>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
