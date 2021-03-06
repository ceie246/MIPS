﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UserInfo.aspx.cs" Inherits="UserInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageBody" Runat="Server">
    <div class="container">
        <div id="subtitle">
            <h1 class="mips246font">Mips246 用户信息</h1>
        </div>
        <div>
            <table class="table table-striped">
                <tr>
                    <td class="userinfoLeft">学号</td>
                    <td class="userinfoRight"><%=StudentId %></td>
                </tr>
                <tr>
                    <td class="userinfoLeft">姓名</td>
                    <td class="userinfoRight"><%=Name %></td>
                </tr>
                <tr>
                    <td class="userinfoLeft">性别</td>
                    <td class="userinfoRight"><%=Sex %></td>
                </tr>
                <tr>
                    <td class="userinfoLeft">专业</td>
                    <td class="userinfoRight"><%=Major %></td>
                </tr>
                <tr>
                    <td class="userinfoLeft">开发板编号</td>
                    <td class="userinfoRight"><%=BoardId %></td>
                </tr>
                <tr>
                    <td class="userinfoLeft">最后登录时间</td>
                    <td class="userinfoRight"><%=LastLoginTime %></td>
                </tr>
                <tr>
                    <td><a class="btn btn-warning" href="ChangePassword.aspx">修改密码</a><a class="btn btn-primary" href="Signout.aspx">登出</a></td>
                    <td></td>
                </tr>
            </table>
        </div>
    </div>

</asp:Content>

