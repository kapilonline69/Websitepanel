<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RDSCreateCollection.ascx.cs" Inherits="WebsitePanel.Portal.RDS.RDSCreateCollection" %>
<%@ Register Src="../UserControls/SimpleMessageBox.ascx" TagName="SimpleMessageBox" TagPrefix="wsp" %>
<%@ Register Src="../UserControls/EnableAsyncTasksSupport.ascx" TagName="EnableAsyncTasksSupport" TagPrefix="wsp" %>
<%@ Register Src="UserControls/RDSCollectionServers.ascx" TagName="CollectionServers" TagPrefix="wsp"%>
<%@ Register TagPrefix="wsp" TagName="CollapsiblePanel" Src="../UserControls/CollapsiblePanel.ascx" %>
<script type="text/javascript" src="/JavaScript/jquery.min.js?v=1.4.4"></script>

<wsp:EnableAsyncTasksSupport id="asyncTasks" runat="server"/>

<div id="ExchangeContainer">
	<div class="Module">
		<div class="Left">
		</div>
		<div class="Content">
			<div class="Center">
				<div class="Title">
					<asp:Image ID="imgAddRDSServer" SkinID="AddRDSServer48" runat="server" />
					<asp:Localize ID="locTitle" runat="server" meta:resourcekey="locTitle" Text="Create New RDS Collection"></asp:Localize>
				</div>
				<div class="FormContentRDS">
				    <wsp:SimpleMessageBox id="messageBox" runat="server" />

					<table>
					    <tr>
						    <td class="FormLabel150" style="width: 100px;"><asp:Localize ID="locCollectionName" runat="server" meta:resourcekey="locCollectionName" Text="Collection Name"></asp:Localize></td>
						    <td>
                                <asp:TextBox ID="txtCollectionName" runat="server" CssClass="TextBox300" />
                                <asp:RequiredFieldValidator ID="valCollectionName" runat="server" ErrorMessage="*" ControlToValidate="txtCollectionName" ValidationGroup="SaveRDSCollection"></asp:RequiredFieldValidator>
						    </td>                            
					    </tr>                        
					</table>                                                                              

                    <fieldset id="RDSServersPanel" runat="server">
                        <legend><asp:Localize ID="locRDSServersSection" runat="server" meta:resourcekey="locRDSServersSection" Text="RDS Servers"></asp:Localize></legend>
                        <div style="padding: 10px;">
                            <wsp:CollectionServers id="servers" runat="server" />
                        </div>  
                    </fieldset>
                      
				    <div class="FormFooter">
					    <asp:Button id="btnSave" runat="server" Text="Save" CssClass="Button1" meta:resourcekey="btnSave" OnClick="btnSave_Click" OnClientClick="ShowProgressDialog('Adding collection...');" ValidationGroup="SaveRDSCollection"></asp:Button>
				    </div>
				</div>
			</div>
		</div>
	</div>
</div>