<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="/">
		<html>
			<head>
				<style>
					.col-lg-4 {
					width: 33.3333%;
					float: left;
					}
				</style>
			</head>
			<body>
				<div class="container-fluid py-4">
					<div class="row mt-auto">
						<xsl:for-each select="items/item">
							<div class="col-lg-4 col-md-6 mt-4 mb-4">
								<a href="/Product?id={id}" class="card z-index-2">
									<div class="card-header p-0 position-relative mt-n4 mx-3 z-index-2 bg-transparent">
										<div class="bg-gradient-secondary shadow-success border-radius-lg py-3 pe-1">
											<div class="text-center">
												<img src="/img/{image}" width="315" height="215" />
											</div>
										</div>
									</div>
									<div class="card-body">
										<h6 class="mb-0">
											<xsl:value-of select="name" />
										</h6>
										<p class="text-sm">
											<xsl:value-of select="description" />
										</p>
										<hr class="dark horizontal" />
										<div class="d-flex">
											<i class="material-icons text-sm my-auto me-1">attach_money</i>
											<p class="mb-0 text-sm">
												<xsl:value-of select="price" />
											</p>
										</div>
									</div>
								</a>
							</div>
						</xsl:for-each>
					</div>
				</div>
			</body>
		</html>
	</xsl:template>

</xsl:stylesheet>
