[v] Add EFModels
����html�令cshtml

=====
[V]add ���U�|���\��
	add Models/Infra/HashUtility.cs
	add AppSettings,<add key="salt" value="ar!Zu@D691RR"/>
	add Models/ViewModels/RegisterVm.cs
	add RegisterExts class,�X�R��k ToMember(RegisterVM)
	add Controllers/Members/MembersController
		add Register action(Get,Post)
		add Views/Memebrs/Register.cshml(**�s�Wdemo���s), RegisterConfirm.cshml 
	�K�X�]�w�n�D(�����]�t1�ӯS��Ÿ��B���o�֩�8�X)
	
[V]	�o�econfirm email���U�H��
	�w����google email�H�e���U�\��
	!**�ק�Email Helper(SendViaGoogle�令�H�H)
	!**modify MembersController
		edit RegisterMember // �o�e���ҫH
		add GenerateConfirmationLink

[V] ��@ �s�|��Email�T�{�\�� 
	�|���ҥΪ�url: /Members/ActiveRegister?memberId=99&confirmCode=ttttttttttt
	modify MembersController
		add ActiveRegister(memberId, confirmCode)
	add Views/Members/ActiveRegister.cshtml

[V] �K�X�s�W�������

[V] ��@ �n�J�n�X����
	�u���b�K���T�ӥB�w�}�q�|���~���\�n�J�A��@���e�Х��ӧO�إߤw/���}�q���|ĳ����
	
	�ثe�w�����n�J�n�X�\��

	modify web.config, add Authenthcation node
	add Models/ViewModels/LoginVm.cs
	modify MemberController
		add Login action(Get, Post)
		add Logout action(get, only)
	modify _layout,�[�Jlogin,logout link

	Controller �[�J[Authorize] �n�J�~���

[V] ��@ �إ߷|���M��/�s��|�����
	add Models/ViewModels/EditProfileVm.cs
	add Models/ViewModels/MemberExts class, �X�R��k ToEditProfileVm(Member)

	modify MemberController
		add Index action �|���M�ϭ�,�b�n�J���\����|�ɦV����
			add Views/Members/Index.cshtml(�ťսd��)�A���Ҳ�Views/Shared/_mod_membernav.cshtml
		�ק�web.config�̪�defaultUrl="/Members/Index/"
		add EditProfile action(Get,Post)
			����s����
	add MemberExts
	�w���\�s��|�����!

[V]��@�ܧ�K�X
	add Models/ViewModels/EditPasswordVm.cs
	
	modifty MemberController
		add EditPassword action(Get, Post)
		add View/Members/EditPassword.cshtml(��create template)


[V]�ѰO�K�X/���]�K�X
	add Models/ViewModels/ForgotPasswordVm.cs
	modifty MemberController
		add ForgotPassword action(Get, Post)
		add ForgotPassword view Page(create template)
		add Views/Members/ForgotPasswordConfirm.cshtml  view Page(�ťսd��)

		�ק� Views/Members/Login.cshtml �[�J"�ѰO�K�X"�s��

[working on] ��@���]�K�X
	add Models/ViewModels/ResetPasswordVm.cs �Ψӭ��s��J�K�X

	modifty MemberController
		add ResetPassword action(Get, Post)
		add Views/Members/ResetPassword.cshtml //���s�]�w�K�X(create)
		add Views/Members/ConfirmResetPassword.cshtml //���s�]�w�K�X�T�{



[]�j�Y�ӭק�
>�w�g���n�Ǩ��Ƨ�
>�W�ǫݳB�z�A�쥻���������i�H�W�Ǧr��ݳB�z�e�{

��ۥ[JS�g��js��Ƨ�

===============
**�s�W��x**