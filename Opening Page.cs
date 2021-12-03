using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Group_Project
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            hideAllPage2();
            hideAllPage3();
            hideAllPage4();
            hideAllPage5();
            hideAllPage6();
            hideAllPage7();
            hideAllPage8();
            hideAllPage9();
            hideAllPage10();
            hideAllPage11();
            hideAllPage12();
            hideAllPage13();
            hideAllPage14();
            hideAllPage15();
        }
        
        private void hideAllPage1()
        {
            mamajoan1.Hide();
            pictureBox1.Hide();
            createAccount1.Hide();
            login1.Hide();
            changeInf1.Hide();
            startOrder1.Hide();
            contactInf1.Hide();
            phone1.Hide();
            email1.Hide();
        }
        private void showAllPage1()
        {
            mamajoan1.Show();
            pictureBox1.Show();
            createAccount1.Show();
            login1.Show();
            changeInf1.Show();
            startOrder1.Show();
            contactInf1.Show();
            phone1.Show();
            email1.Show();
        }
        private void hideAllPage2()
        {
            junction2.Hide();
            change_checkInfo2.Hide();
            change_cardInfo2.Hide();
            change_Login2.Hide();

        }
        private void showAllPage2()
        {
            junction2.Show();
            change_checkInfo2.Show();
            change_cardInfo2.Show();
            change_Login2.Show();
        }
        private void hideAllPage3()
        {
            p3_back_Button3.Hide();
            p3_home_Button3.Hide();
            p3_help_Button3.Hide();
            p3_noAccount.Hide();
            p3_passwordEnter.Hide();    
            p3_password_textBox.Hide();
            p3_phoneNumber_textBox.Hide();
            p3_phone_Number_txt.Hide();
            p3_signIn3.Hide();
            p3_submit_Button3.Hide();
            p3_alreadyorder.Hide();
        }
        private void showAllPage3()
        {
            p3_back_Button3.Show();
            p3_home_Button3.Show();
            p3_help_Button3.Show();
            p3_noAccount.Show();
            p3_passwordEnter.Show();
            p3_password_textBox.Show();
            p3_phoneNumber_textBox.Show();
            p3_phone_Number_txt.Show();
            p3_signIn3.Show();
            p3_submit_Button3.Show();
            p3_alreadyorder.Show();
        }
        private void hideAllPage4()
        {
            p4_back_Button4.Hide();
            p4_changePass.Hide();
            p4_confirmNewPassword_textBox.Hide();
            p4_currentPassword_textBox.Hide();
            p4_connewpass.Hide();
            p4_currpass.Hide();
            p4_help_Button4.Hide();
            p4_home_Button4.Hide();
            p4_newpass.Hide();
            p4_newPassword_textBox.Hide();
            p4_submit4.Hide();
            
        }
        private void showAllPage4()
        {
            p4_back_Button4.Show();
            p4_changePass.Show();
            p4_confirmNewPassword_textBox.Show();
            p4_currentPassword_textBox.Show();
            p4_connewpass.Show();
            p4_currpass.Show();
            p4_help_Button4.Show();
            p4_home_Button4.Show();
            p4_newpass.Show();
            p4_newPassword_textBox.Show();
            p4_submit4.Show();
        }
        private void hideAllPage5()
        {
            p5_address.Hide();
            p5_address_textBox.Hide();
            p5_back_Button5.Hide();
            p5_cardInf.Hide();
            p5_closeInt_textBox.Hide();
            p5_closest.Hide();
            p5_create.Hide();
            p5_help_Button5.Hide();
            p5_home_button5.Hide();
            p5_name.Hide();
            p5_name_textBox.Hide();
            p5_phone.Hide();
            p5_phoneNumber_textBox.Hide();
            p5_save.Hide(); 
        }
        private void ShowAllPage5()
        {
            p5_address.Show();
            p5_address_textBox.Show();
            p5_back_Button5.Show();
            p5_cardInf.Show();
            p5_closeInt_textBox.Show();
            p5_closest.Show();
            p5_create.Show();
            p5_help_Button5.Show();
            p5_home_button5.Show();
            p5_name.Show();
            p5_name_textBox.Show();
            p5_phone.Show();
            p5_phoneNumber_textBox.Show();
            p5_save.Show();
        }
        private void hideAllPage6()
        {
            p6_americanEx5.Hide();
            p6_back5.Hide();
            p6_cardCVV.Hide();
            p6_cardInformation5.Hide();
            p6_cardNumber5.Hide();
            p6_cardNum_textBox.Hide();
            p6_credit5.Hide();
            p6_cvv_textBox.Hide();
            p6_visa5.Hide();
            p6_submit5.Hide();
            p6_save5.Hide();
            p6_master5.Hide();
            p6_home5.Hide();
            p6_help5.Hide();
            p6_expirationDate5.Hide();
            p6_expDate_textBox.Hide();
            p6_debitOrCredit5.Hide();
            p6_debit5.Hide();
            p6_discover5.Hide();
            p6_typeOfCard5.Hide();
            
            

         

        }
        private void showAllPage6()
        {
            p6_americanEx5.Show();
            p6_back5.Show();
            p6_cardCVV.Show();
            p6_cardInformation5.Show();
            p6_cardNumber5.Show();
            p6_cardNum_textBox.Show();
            p6_credit5.Show();
            p6_cvv_textBox.Show();
            p6_visa5.Show();
            p6_submit5.Show();
            p6_save5.Show();
            p6_master5.Show();
            p6_home5.Show();
            p6_help5.Show();
            p6_expirationDate5.Show();
            p6_expDate_textBox.Show();
            p6_debitOrCredit5.Show();
            p6_debit5.Show();
            p6_discover5.Show();
            p6_typeOfCard5.Show();

        }
        private void hideAllPage7()
        {
            p7_submit.Hide();
            p7_accBox.Hide();
            p7_accountnum.Hide();
            p7_back.Hide();
            p7_check.Hide();
            p7_dateBox.Hide();
            p7_help.Hide();
            p7_home.Hide();
            p7_payam.Hide();
            p7_payBox.Hide();   
            p7_paydate.Hide();
            p7_route.Hide();
            p7_routeBox.Hide();
            p7_save.Hide();

        }
        private void showAllPage7()
        {
            p7_submit.Show();
            p7_accBox.Show();
            p7_accountnum.Show();
            p7_back.Show();
            p7_check.Show();
            p7_dateBox.Show();
            p7_help.Show();
            p7_home.Show();
            p7_payam.Show();
            p7_payBox.Show();
            p7_paydate.Show();
            p7_route.Show();
            p7_routeBox.Show();
            p7_save.Show();

        }
        private void showAllPage8()
        {
            p8_back.Show();
            p8_choosesize.Show();
            p8_crusade.Show();
            p8_help.Show();
            p8_home.Show();
            p8_large.Show();
            p8_medium.Show();
            p8_next.Show();
            p8_small.Show();    
          

        }
        private void hideAllPage8()
        {
            p8_back.Hide();
            p8_choosesize.Hide();
            p8_crusade.Hide();
            p8_help.Hide();
            p8_home.Hide();
            p8_large.Hide();
            p8_medium.Hide();
            p8_next.Hide();
            p8_small.Hide();


        }
        private void hideAllPage9()
        {
            p9_alfredo.Hide();
            p9_back.Hide(); 
            p9_bbq.Hide();  
            p9_help.Hide(); 
            p9_home.Hide();
            p9_next.Hide();
            p9_none.Hide();
            p9_pizzasauce.Hide();
            p9_regular.Hide();
            

        }
        private void showAllPage9()
        {
            p9_alfredo.Show();
            p9_back.Show();
            p9_bbq.Show();
            p9_help.Show();
            p9_home.Show();
            p9_next.Show();
            p9_none.Show();
            p9_pizzasauce.Show();
            p9_regular.Show();


        }
        private void showAllPage10()
        {
            p10_back.Show();
            p10_choosecrust.Show();
            p10_help.Show();
            p10_home.Show();
            p10_next.Show();
            p10_reg.Show();
            p10_stuff.Show(); 
            p10_thin.Show();
            
        }
        private void hideAllPage10()
        {
            p10_back.Hide();
            p10_choosecrust.Hide();
            p10_help.Hide();
            p10_home.Hide();
            p10_next.Hide();
            p10_reg.Hide();
            p10_stuff.Hide();
            p10_thin.Hide();

        }
        private void showAllPage11()
        {
            p11_back.Show();
            p11_bacon.Show();
            p11_cheese.Show();
            p11_doub.Show();
            p11_ham.Show();
            p11_help.Show();    
            p11_home.Show();
            p11_labeltop.Show();
            p11_meatcombo.Show();
            p11_mush.Show();
            p11_next.Show();
            p11_olive.Show();
            p11_pepp.Show();
            p11_pine.Show();
            p11_veglove.Show(); 
        }
        private void hideAllPage11()
        {
            p11_back.Hide();
            p11_bacon.Hide();
            p11_cheese.Hide();
            p11_doub.Hide();
            p11_ham.Hide();
            p11_help.Hide();
            p11_home.Hide();
            p11_labeltop.Hide();
            p11_meatcombo.Hide();
            p11_mush.Hide();
            p11_next.Hide();
            p11_olive.Hide();
            p11_pepp.Hide();
            p11_pine.Hide();
            p11_veglove.Hide();
        }
        private void showAllPage12()
        {
            p12_back.Show();
            p12_bevlabel.Show();
            p12_coke.Show();
            p12_diet.Show();
            p12_dr.Show();
            p12_homebutton.Show();
            p12_home.Show();
            p12_large.Show();
            p12_medium.Show();
            p12_next.Show();
            p12_orderagain.Show();
            p12_pepsi.Show();
            p12_small.Show();
            p12_sprite.Show();
        
        }
        private void hideAllPage12()
        {
            p12_back.Hide();
            p12_bevlabel.Hide();
            p12_coke.Hide();
            p12_diet.Hide();
            p12_dr.Hide();
            p12_homebutton.Hide();
            p12_large.Hide();
            p12_medium.Hide();
            p12_next.Hide();
            p12_orderagain.Hide();
            p12_pepsi.Hide();
            p12_small.Hide();
            p12_sprite.Hide();
            p12_home.Hide();

        }
        private void showAllPage13()
        {
            p13_addmore.Show();
            p13_back.Show();
            p13_home.Show();
            p13_items.Show();
            p13_modify.Show();
            p13_modpizza1.Show();
            p13_modpizza2.Show();
            p13_modpizza3.Show();
            p13_pizza1desc.Show();
            p13_pizza2desc.Show();
            p13_pizza3desc.Show();
            p13_proceed.Show();
            p13_remove.Show();
            p13_removepizza1.Show();
            p13_removepizza2.Show();
            p13_removepizza3.Show();
            p13_reviewlabel.Show();


        }
        private void hideAllPage13()
        {
            p13_addmore.Hide();
            p13_back.Hide();
            p13_home.Hide();
            p13_items.Hide();
            p13_modify.Hide();
            p13_modpizza1.Hide();
            p13_modpizza2.Hide();
            p13_modpizza3.Hide();
            p13_pizza1desc.Hide();
            p13_pizza2desc.Hide();
            p13_pizza3desc.Hide();
            p13_proceed.Hide();
            p13_remove.Hide();
            p13_removepizza1.Hide();
            p13_removepizza2.Hide();
            p13_removepizza3.Hide();
            p13_reviewlabel.Hide();


        }
        private void showAllPage14()
        {
            p14_back.Show();
            p14_caltip.Show();
            p14_card.Show();
            p14_carryout.Show();
            p14_cash.Show();
            p14_check.Show();
            p14_delivery.Show();
            p14_finalize.Show();
            p14_Help.Show();
            p14_Home.Show();
            p14_label.Show();
            p14_orderanother.Show();
            p14_tip.Show();
            p14_total.Show();
            p14_tipBox.Show();
            p14_totalprice.Show();
        }
        private void hideAllPage14()
        {
            p14_back.Hide();
            p14_caltip.Hide();
            p14_card.Hide();
            p14_carryout.Hide();
            p14_cash.Hide();
            p14_check.Hide();
            p14_delivery.Hide();
            p14_finalize.Hide();
            p14_Help.Hide();
            p14_Home.Hide();
            p14_label.Hide();
            p14_orderanother.Hide();
            p14_tip.Hide();
            p14_total.Hide();
            p14_totalprice.Hide();
            p14_tipBox.Hide();
        }
        private void hideAllPage15()
        {
            p15_back.Hide();
            p15_carddir.Hide();
            p15_change.Hide();
            p15_help.Hide();
            p15_signin.Hide();
            p15_home.Hide();
            p15_translabel.Hide();
        }
        private void showAllPage15()
        {
            p15_back.Show();
            p15_carddir.Show();
            p15_signin.Show();
            p15_change.Show();
            p15_help.Show();
            p15_home.Show();
            p15_translabel.Show();
        }
        private void showAllPage16()
        {
            p16_contact.Show();
            p16_mamajaon.Show();
            p16_mamama.Show();
            p16_trackorder.Show();
            p16_wait.Show();
        }
        private void hideAllPage16()
        {
            p16_contact.Hide();
            p16_mamajaon.Hide();
            p16_mamama.Hide();
            p16_trackorder.Hide();
            p16_wait.Hide();
        }
        String p3_phone, p3_pass, p4_current, p4_new, p4_confirm, p5_Name, p5_Phone, p5_password, p5_Address, p6_debCred, p6_cardNum, p6_expDate, p6_CVV, p6_cardType;
        bool junctioning = false,dontHave=false,loggedin=false, removed=false;
        String p7_routeNum, p7_account, p7_payment, p7_paymentdate, p8_size, p9_sauce, p10_crust,p12_beverage, p12_bevsize, p14_aquisition, p14_paymentType;
        int numofTops = 0, run=1;
        double pizzaprice1 = 0, pizzaprice2 = 0, pizzaprice3 = 0, pizza1tip=0,pizza2tip=0,pizza3tip=0;
        Customer newCust = new Customer();
        Pizzas newPizza = new Pizzas();
        Pizzas newPizza2 = new Pizzas();
        Pizzas newPizza3 = new Pizzas();
        private void button1_Click(object sender, EventArgs e)
        {
            hideAllPage1();
            showAllPage3();
            junctioning = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowAllPage5();
            hideAllPage1();
            dontHave = false;
            junctioning = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideAllPage1();
            showAllPage2();
        }

        private void startOrder1_Click(object sender, EventArgs e)
        {
            junctioning = false;
            if (loggedin)
            {
                showAllPage8();
                hideAllPage1();
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void email1_Click(object sender, EventArgs e)
        {

        }

        private void phone1_Click(object sender, EventArgs e)
        {

        }

        private void contactInf1_Click(object sender, EventArgs e)
        {

        }

        private void mamajoan1_Click(object sender, EventArgs e)
        {

        }

        private void back_Button3_Click(object sender, EventArgs e)
        {
            hideAllPage3();
            showAllPage1();
        }

        private void home_Button3_Click(object sender, EventArgs e)
        {
            hideAllPage3();
            showAllPage1();
        }

        private void p3_submit_Button3_Click(object sender, EventArgs e)
        {
            if (p3_pass == newCust.Password && p3_phone == newCust.PhoneNumber)
            {
                hideAllPage3();
                showAllPage1();
                loggedin = true;
            }
            
        }

        private void p3_noAccount_Click(object sender, EventArgs e)
        {
            hideAllPage3();
            ShowAllPage5();
            dontHave = true;
        }

        private void p3_phoneNumber_textBox_TextChanged(object sender, EventArgs e)
        {
            p3_phone = p3_phoneNumber_textBox.Text;
        }

        private void p3_password_textBox_TextChanged(object sender, EventArgs e)
        {
            p3_pass = p3_password_textBox.Text;
        }

        private void change_Login2_Click(object sender, EventArgs e)
        {
            hideAllPage2();
            showAllPage4();
        }

        private void p5_name_textBox_TextChanged(object sender, EventArgs e)
        {
            p5_Name = p5_name_textBox.Text;
        }

        private void p5_phoneNumber_textBox_TextChanged(object sender, EventArgs e)
        {
            p5_Phone = p5_phoneNumber_textBox.Text;
            newCust.PhoneNumber = p5_Phone;
        }

        private void p5_address_textBox_TextChanged(object sender, EventArgs e)
        {
            p5_Address = p5_address_textBox.Text;
        }

        private void p5_closeInt_textBox_TextChanged(object sender, EventArgs e)
        {
            p5_password = p5_closeInt_textBox.Text;
            newCust.Password = p5_password;
        }

        private void p6_back5_Click(object sender, EventArgs e)
        {
            if (junctioning)
            {
                hideAllPage6();
                showAllPage2();
            }
            else { 
            hideAllPage6();
            ShowAllPage5();
            }
        }

        private void p6_home5_Click(object sender, EventArgs e)
        {
            hideAllPage6();
            showAllPage1();
        }

        private void p6_debit5_Click(object sender, EventArgs e)
        {
            p6_debCred = "Debit";
        }

        private void p6_credit5_Click(object sender, EventArgs e)
        {
            p6_debCred = "Credit";
        }

        private void p6_discover5_Click(object sender, EventArgs e)
        {
            p6_cardType = "Discover";
        }

        private void p6_master5_Click(object sender, EventArgs e)
        {
            p6_cardType = "Master Card";
        }

        private void p6_americanEx5_Click(object sender, EventArgs e)
        {
            p6_cardType = "American Express";
        }

        private void p6_cardNum_textBox_TextChanged(object sender, EventArgs e)
        {
            p6_cardNum = p6_cardNum_textBox.Text;
        }

        private void p6_expDate_textBox_TextChanged(object sender, EventArgs e)
        {
            p6_expDate = p6_expDate_textBox.Text;   
        }

        private void p6_cvv_textBox_TextChanged(object sender, EventArgs e)
        {
            p6_CVV = p6_cvv_textBox.Text;
        }

        private void p6_submit5_Click(object sender, EventArgs e)
        {
            if(p6_CVV == null || p6_CVV == "" || p6_cardType == null || p6_cardType == "" || p6_expDate == null || p6_expDate == "" || p6_cardNum == null || p6_cardNum == "" || p6_debCred == null || p6_debCred == ""){

            }
            else
            {
                hideAllPage6();
                showAllPage1();
            }
        }

        private void p7_back_Click(object sender, EventArgs e)
        {
            if (junctioning)
            {
                showAllPage2();
                hideAllPage7();
            }
            else
            {
                showAllPage6();
                showAllPage1();
            }
        }

        private void p7_submit_Click(object sender, EventArgs e)
        {
            showAllPage1();
            hideAllPage7();
        }

        private void p7_help_Click(object sender, EventArgs e)
        {

        }

        private void p7_dateBox_TextChanged(object sender, EventArgs e)
        {
            p7_paymentdate=p7_dateBox.Text;
        }

        private void p7_payBox_TextChanged(object sender, EventArgs e)
        {
            p7_payment = p7_payBox.Text;
        }

        private void p7_accBox_TextChanged(object sender, EventArgs e)
        {
            p7_account = p7_accBox.Text;
        }

        private void p7_routeBox_TextChanged(object sender, EventArgs e)
        {
            p7_routeNum = p7_routeBox.Text;
        }

        private void p7_paydate_Click(object sender, EventArgs e)
        {

        }

        private void p7_payam_Click(object sender, EventArgs e)
        {

        }

        private void p7_accountnum_Click(object sender, EventArgs e)
        {

        }

        private void p7_route_Click(object sender, EventArgs e)
        {

        }

        private void p7_check_Click(object sender, EventArgs e)
        {

        }

        private void p8_back_Click(object sender, EventArgs e)
        {
            showAllPage1();
            hideAllPage8();
        }

        private void p8_help_Click(object sender, EventArgs e)
        {

        }

        private void p8_crusade_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
              
                pizzaprice1 = 17.99;
                newPizza.size = "Crusade";
            }
            if(run == 2)
            {
                newPizza2.size = "Crusade";
                pizzaprice2 = 17.99;
            }
            if (run == 3)
            {
                newPizza3.size = "Crusade";
                pizzaprice3 = 17.99;
            }
            p8_size = "Crusade";
        }

        private void p8_large_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.size = "Large";
                pizzaprice1 = 12.99;
            }
            if (run == 2)
            {
                newPizza2.size = "Large";
                pizzaprice2 = 12.99;
            }
            if (run == 3)
            {
                newPizza3.size = "Large";
                pizzaprice3 = 12.99;
            }
            p8_size = "Large";
        }

        private void p8_medium_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.size = "Medium";
                pizzaprice1 = 10.99;
            }
            if (run == 2)
            {
                newPizza2.size = "Medium";
                pizzaprice2 = 10.99;
            }
            if (run == 3)
            {
                newPizza3.size = "Medium";
                pizzaprice3 = 10.99;
            }
            p8_size = "Medium";
        }

        private void p8_small_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.size = "Small";
                pizzaprice1 = 8.99;
            }
            if (run == 2)
            {
                newPizza2.size = "Small";
                pizzaprice2 = 8.99;
            }
            if (run == 3)
            {
                newPizza3.size = "Small";
                pizzaprice3 = 8.99;
            }
            p8_size = "Small";
        }

        private void p8_choosesize_Click(object sender, EventArgs e)
        {

        }

        private void p9_home_Click(object sender, EventArgs e)
        {
            showAllPage1();
            hideAllPage9();

        }

        private void p9_regular_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.sauce = "Regular";
                
            }
            if (run == 2)
            {
                newPizza2.sauce = "Regular";
                
            }
            if (run == 3)
            {
                newPizza3.sauce = "Regular";
               
            }
            p9_sauce = "Regular";
        }

        private void p9_alfredo_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.sauce = "Alfredo";

            }
            if (run == 2)
            {
                newPizza2.sauce = "Alfredo";

            }
            if (run == 3)
            {
                newPizza3.sauce = "Alfredo";

            }
            p9_sauce = "Alfredo";
        }

        private void p9_bbq_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.sauce = "BBQ";

            }
            if (run == 2)
            {
                newPizza2.sauce = "BBQ";

            }
            if (run == 3)
            {
                newPizza3.sauce = "BBQ";

            }
            p9_sauce = "BBQ";
        }

        private void p9_none_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.sauce = "None";

            }
            if (run == 2)
            {
                newPizza2.sauce = "None";

            }
            if (run == 3)
            {
                newPizza3.sauce = "None";

            }
            p9_sauce = "None";
        }

        private void p9_next_Click(object sender, EventArgs e)
        {
            if (p9_sauce == null || p9_sauce == "")
            {

            }
            else
            {
                hideAllPage9();
                showAllPage10();
            }
        }

        private void p10_back_Click(object sender, EventArgs e)
        {
            hideAllPage10();
            showAllPage9();
        }

        private void p10_help_Click(object sender, EventArgs e)
        {

        }

        private void p10_stuff_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.crust = "Stuffed";

            }
            if (run == 2)
            {
                newPizza2.crust = "Stuffed";

            }
            if (run == 3)
            {
                newPizza3.crust = "Stuffed";

            }
            p10_crust = "Stuffed";
        }

        private void p10_reg_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.crust = "Regular";

            }
            if (run == 2)
            {
                newPizza2.crust = "Regular";

            }
            if (run == 3)
            {
                newPizza3.crust = "Regular";

            }
            p10_crust = "Regular";
        }

        private void p10_thin_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.crust = "Thin";

            }
            if (run == 2)
            {
                newPizza2.crust = "Thin";

            }
            if (run == 3)
            {
                newPizza3.crust = "Thin";

            }
            p10_crust = "Thin";
        }

        private void p10_choosecrust_Click(object sender, EventArgs e)
        {

        }

        private void p10_home_Click(object sender, EventArgs e)
        {
            showAllPage1();
            hideAllPage10();
        }

        private void p11_back_Click(object sender, EventArgs e)
        {
            showAllPage10();
            hideAllPage11();
        }

        private void p11_home_Click(object sender, EventArgs e)
        {
            showAllPage1();
            hideAllPage11();
        }

        private void p11_next_Click(object sender, EventArgs e)
        {
            hideAllPage11();
            showAllPage12();
        }

        private void p11_cheese_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.toppings = ++newPizza.toppings;

            }
            if (run == 2)
            {
                newPizza2.toppings = ++newPizza2.toppings;

            }
            if (run == 3)
            {
                newPizza3.toppings = ++newPizza3.toppings;

            }
        }

        private void p11_pepp_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.toppings = ++newPizza.toppings;

            }
            if (run == 2)
            {
                newPizza2.toppings = ++newPizza2.toppings;

            }
            if (run == 3)
            {
                newPizza3.toppings = ++newPizza3.toppings;

            }
        }

        private void p11_bacon_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.toppings = ++newPizza.toppings;

            }
            if (run == 2)
            {
                newPizza2.toppings = ++newPizza2.toppings;

            }
            if (run == 3)
            {
                newPizza3.toppings = ++newPizza3.toppings;

            }
        }

        private void p11_ham_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.toppings = ++newPizza.toppings;

            }
            if (run == 2)
            {
                newPizza2.toppings = ++newPizza2.toppings;

            }
            if (run == 3)
            {
                newPizza3.toppings = ++newPizza3.toppings;

            }
        }

        private void p11_pine_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.toppings = ++newPizza.toppings;

            }
            if (run == 2)
            {
                newPizza2.toppings = ++newPizza2.toppings;

            }
            if (run == 3)
            {
                newPizza3.toppings = ++newPizza3.toppings;

            }
        }

        private void p11_mush_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.toppings = newPizza.toppings++;

            }
            if (run == 2)
            {
                newPizza2.toppings = ++newPizza2.toppings;

            }
            if (run == 3)
            {
                newPizza3.toppings = ++newPizza3.toppings;

            }
        }

        private void p11_olive_Click(object sender, EventArgs e)
        {

            if (run == 1)
            {
                newPizza.toppings = ++newPizza.toppings;

            }
            if (run == 2)
            {
                newPizza2.toppings = ++newPizza2.toppings;

            }
            if (run == 3)
            {
                newPizza3.toppings = ++newPizza3.toppings;

            }
        }

        private void p12_back_Click(object sender, EventArgs e)
        {
            showAllPage11();
            hideAllPage12();
        }

        private void p12_medium_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.beverage_size = "Medium";

            }
            if (run == 2)
            {
                newPizza2.beverage_size = "Medium";

            }
            if (run == 3)
            {
                newPizza3.beverage_size = "Medium";

            }
            p12_bevsize = "Medium";
        }

        private void p12_small_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.beverage_size = "Small";

            }
            if (run == 2)
            {
                newPizza2.beverage_size = "Small";

            }
            if (run == 3)
            {
                newPizza3.beverage_size = "Small";

            }
            p12_bevsize = "Small";
        }

        private void p12_dr_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.beverage = "Dr. Pepper";

            }
            if (run == 2)
            {
                newPizza2.beverage = "Dr. Pepper";

            }
            if (run == 3)
            {
                newPizza3.beverage = "Dr. Pepper";

            }
            p12_beverage = "Dr. Pepper";
        }

        private void p12_pepsi_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.beverage = "Pepsi";

            }
            if (run == 2)
            {
                newPizza2.beverage = "Pepsi";

            }
            if (run == 3)
            {
                newPizza3.beverage = "Pepsi";

            }
            p12_beverage = "Pepsi";
        }

        private void p12_sprite_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.beverage = "Sprite";

            }
            if (run == 2)
            {
                newPizza2.beverage = "Sprite";

            }
            if (run == 3)
            {
                newPizza3.beverage = "Sprite";

            }
            p12_beverage = "Sprite";
        }

        private void p12_coke_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.beverage = "Coke";

            }
            if (run == 2)
            {
                newPizza2.beverage = "Coke";

            }
            if (run == 3)
            {
                newPizza3.beverage = "Coke";

            }
            p12_beverage = "Coke";
        }

        private void p12_bevlabel_Click(object sender, EventArgs e)
        {

        }

        private void p12_diet_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.beverage = "Diet Coke";

            }
            if (run == 2)
            {
                newPizza2.beverage = "Diet Coke";

            }
            if (run == 3)
            {
                newPizza3.beverage = "Diet Coke";

            }
            p12_beverage = "Diet Coke";
        }

        private void p12_orderagain_Click(object sender, EventArgs e)
        {
            run++;
            hideAllPage12();
            showAllPage8();
        }

        private void p12_next_Click(object sender, EventArgs e)
        {
            if (p12_beverage == null || p12_beverage == ""||p12_bevsize==null||p12_bevsize=="")
            {

            }
            else
            {
                showAllPage13();
                hideAllPage12();
                if (newPizza.size != null) {
                    p13_pizza1desc.Text = ""+newPizza.size + " pizza with " + newPizza.sauce + " sauce and " + newPizza.crust + " crust. " + newPizza.toppings + " toppings and a " + newPizza.beverage_size +" "+ newPizza.beverage + ".";
                 }
                if (newPizza2.size != null)
                {
                    p13_pizza2desc.Text = "" + newPizza2.size + " pizza with " + newPizza2.sauce + " sauce and " + newPizza2.crust + " crust. " + newPizza2.toppings + " toppings and a " + newPizza2.beverage_size +" "+ newPizza2.beverage + ".";
                }
                if (newPizza3.size != null)
                {
                    p13_pizza3desc.Text = "" + newPizza3.size + " pizza with " + newPizza3.sauce + " sauce and " + newPizza3.crust + " crust. " + newPizza3.toppings + " toppings and a " + newPizza3.beverage_size +" "+ newPizza3.beverage + ".";
                }
            }
        }

        private void p12_homebutton_Click(object sender, EventArgs e)
        {

        }

        private void p13_back_Click(object sender, EventArgs e)
        {
            hideAllPage13();
            showAllPage12();
        }

        private void p13_home_Click(object sender, EventArgs e)
        {
            hideAllPage13();
            showAllPage1();
        }

        private void p13_proceed_Click(object sender, EventArgs e)
        {
            hideAllPage13();
            showAllPage14();
            p14_totalprice.Text = "" + (newPizza.tip + pizzaprice1 + newPizza2.tip + pizzaprice2 + newPizza3.tip + pizzaprice3);
        }

        private void p13_addmore_Click(object sender, EventArgs e)
        {
            if (run == 4)
            {
                Console.WriteLine("Can't Add More!");
            }
            if (removed)
            {
                numofTops = 0;
                hideAllPage13();
                showAllPage8();
            }
            else
            {
                run++;
                numofTops = 0;
                hideAllPage13();
                showAllPage8();
            }
            

        }

        private void p13_removepizza1_Click(object sender, EventArgs e)
        {
            run = 1;
            newPizza.clear();
            p13_pizza1desc.Text = "Removed";
            removed = true;
        }

        private void p13_removepizza2_Click(object sender, EventArgs e)
        {
            run = 2;
            newPizza2.clear();
            p13_pizza2desc.Text = "Removed";
            removed = true;
        }

        private void p13_removepizza3_Click(object sender, EventArgs e)
        {
            run = 3;
            newPizza3.clear();
            p13_pizza3desc.Text = "Removed";
            removed = true;
        }

        private void p13_modpizza1_Click(object sender, EventArgs e)
        {
            showAllPage8();
            hideAllPage13();
            run = 1;
            newPizza.clear();
        }

        private void p13_modpizza2_Click(object sender, EventArgs e)
        {
            showAllPage8();
            hideAllPage13();
            run = 2;
            newPizza2.clear();
        }

        private void p13_modpizza3_Click(object sender, EventArgs e)
        {
            showAllPage8();
            hideAllPage13();
            run = 3;
            newPizza3.clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void p14_back_Click(object sender, EventArgs e)
        {
            showAllPage13();
            hideAllPage14(); 
        }

        private void p14_card_Click(object sender, EventArgs e)
        {
            p14_paymentType = "Card";
        }

        private void p14_cash_Click(object sender, EventArgs e)
        {
            p14_paymentType = "Cash";
        }

        private void p14_carryout_Click(object sender, EventArgs e)
        {
            p14_aquisition = "Carryout";
        }

        private void p14_delivery_Click(object sender, EventArgs e)
        {
            p14_aquisition = "Delivery";
        }

        private void p14_caltip_Click(object sender, EventArgs e) //this calculates tip, we need a box to display the calculation, just add it to the p14 group
        {
            if(run==1){
                pizza1tip = pizzaprice1 * 0.15;
            }
            if (run == 2)
            {
                pizza2tip = pizzaprice2 * 0.15;

            }
            if (run == 3)
            {
                pizza3tip = pizzaprice3 * 0.15;
            }
            
        }

        private void p14_label_Click(object sender, EventArgs e)
        {

        }

       

        private void p14_tipBox_TextChanged(object sender, EventArgs e)
        {
            switch(run)
            {
                default:
                    {
                        if (p14_tipBox.Text == null)
                            newPizza.tip = 0;
                        else
                        newPizza.tip = Double.Parse(p14_tipBox.Text);//if null parse
                        break;
                    }
                case 2:
                    {
                        if (p14_tipBox.Text == null)
                            newPizza2.tip = 0;
                        else
                            newPizza2.tip = Double.Parse(p14_tipBox.Text);
                        break;
                    }
                case 3:
                    {
                        if (p14_tipBox.Text == null)
                            newPizza3.tip = 0;
                        else
                            newPizza3.tip = Double.Parse(p14_tipBox.Text);
                        break;
                    }
                
            }
            p14_totalprice.Text = "" + (newPizza.tip + pizzaprice1 + newPizza2.tip + pizzaprice2 + newPizza3.tip + pizzaprice3);

            
        }

        private void p14_total_Click(object sender, EventArgs e)
        {

        }

        private void p14_tip_Click(object sender, EventArgs e)
        {

        }

        private void p15_home_Click(object sender, EventArgs e)
        {
            showAllPage1();
            hideAllPage15();
        }

        private void p15_carddir_Click(object sender, EventArgs e)
        {
            showAllPage6();
            hideAllPage15();
        }

        private void p15_signin_Click(object sender, EventArgs e)
        {
            showAllPage3();
            hideAllPage15();
        }

        private void p15_help_Click(object sender, EventArgs e)
        {

        }

        private void p15_back_Click(object sender, EventArgs e)
        {
            showAllPage14();
            hideAllPage15();
        }

        private void p15_change_Click(object sender, EventArgs e)
        {

        }

        private void p15_translabel_Click(object sender, EventArgs e)
        {

        }

        private void p3_alreadyorder_Click(object sender, EventArgs e)
        {
            hideAllPage3();
            showAllPage15();
        }

        private void p14_orderanother_Click(object sender, EventArgs e)
        {
            if (run == 3)
            {
                Console.WriteLine("no.");
            }
            else
            {
                hideAllPage14();
                showAllPage8();
            }
        }

        private void p14_finalize_Click(object sender, EventArgs e)
        {
            hideAllPage14();

        }

        private void p14_totalprice_Click(object sender, EventArgs e)
        {

        }

        private void p14_Help_Click(object sender, EventArgs e)
        {

        }

        private void p14_Home_Click(object sender, EventArgs e)
        {
            showAllPage1();
            hideAllPage14();
        }

        private void p14_check_Click(object sender, EventArgs e)
        {
            p14_paymentType = "Check";
        }

        private void p12_home_Click(object sender, EventArgs e)
        {
            showAllPage1();
            hideAllPage12();
        }

        private void p12_large_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.beverage_size = "Large";

            }
            if (run == 2)
            {
                newPizza2.beverage_size = "Large";

            }
            if (run == 3)
            {
                newPizza3.beverage_size = "Large";

            }
            p12_bevsize = "Large";
        }

        private void p11_doub_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.toppings = newPizza.toppings++;

            }
            if (run == 2)
            {
                newPizza2.toppings = newPizza.toppings++;

            }
            if (run == 3)
            {
                newPizza3.toppings = newPizza.toppings++;

            }
        }

        private void p11_meatcombo_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.toppings = newPizza.toppings++;

            }
            if (run == 2)
            {
                newPizza2.toppings = newPizza.toppings++;

            }
            if (run == 3)
            {
                newPizza3.toppings = newPizza.toppings++;

            }
        }

        private void p11_veglove_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                newPizza.toppings = newPizza.toppings++;

            }
            if (run == 2)
            {
                newPizza2.toppings = newPizza.toppings++;

            }
            if (run == 3)
            {
                newPizza3.toppings = newPizza.toppings++;

            }
        }

        private void p10_next_Click(object sender, EventArgs e)
        {
            hideAllPage10();
            showAllPage11();
        }

        private void p9_back_Click(object sender, EventArgs e)
        {
            showAllPage8();
            hideAllPage9();
        }

        private void p8_home_Click(object sender, EventArgs e)
        {
            showAllPage1();
            hideAllPage8();
        }

        private void p8_next_Click(object sender, EventArgs e)
        {
            if (p8_size == null || p8_size == "")
            {

            }
            else
            {
                hideAllPage8();
                showAllPage9();
            }
        }

        private void p7_home_Click(object sender, EventArgs e)
        {
            junctioning = false;
            showAllPage1();
            hideAllPage7();
        }

        private void p7_save_Click(object sender, EventArgs e)
        {

        }

        private void change_checkInfo2_Click(object sender, EventArgs e)
        {
            showAllPage7();
            junctioning = true;
            hideAllPage1();
            hideAllPage2();
        }

        private void change_cardInfo2_Click(object sender, EventArgs e)
        {
            showAllPage6();
            hideAllPage2();
            junctioning = true;
        }

        private void p6_visa5_Click(object sender, EventArgs e)
        {
            p6_cardType = "Visa";
        }

        private void p5_home_button5_Click(object sender, EventArgs e)
        {
            showAllPage1();
            hideAllPage5();
        }

        private void p5_back_Button5_Click(object sender, EventArgs e)
        {
            if (dontHave)
            {
                showAllPage3();
                hideAllPage5();
            }
            else
            {
                showAllPage1();
                hideAllPage5();
            }
            
        }

        private void p5_save_Click(object sender, EventArgs e)
        {

        }

    
        private void p5_create_Click(object sender, EventArgs e)
        {

        }

       

        private void p4_newPassword_textBox_TextChanged(object sender, EventArgs e)
        {
            p4_new = p4_newPassword_textBox.Text;
        }

        private void p4_confirmNewPassword_textBox_TextChanged(object sender, EventArgs e)
        {
            p4_confirm = p4_confirmNewPassword_textBox.Text;
        }

        private void p4_submit4_Click(object sender, EventArgs e)
        {
            if (p4_current == null || p4_current == "" || p4_new == null || p4_new == "" || p4_confirm == null || p4_confirm == "")
            {

            }
            else if (p4_new == p4_confirm)
            {
                newCust.Password = p4_confirm;
                showAllPage1();
                hideAllPage4();
            }
            
        }

        private void p5_cardInf_Click(object sender, EventArgs e)
        {
            if(p5_Name==null || p5_Name == "" || p5_Phone == null || p5_Phone == "" || p5_password == null || p5_password == "" || p5_Address == null || p5_Address == "")
            {

            }
            else
            {
                showAllPage6();
                hideAllPage5();
            }
        }

        private void p4_back_Button4_Click(object sender, EventArgs e)
        {
            if (junctioning) {
                hideAllPage4();
                showAllPage2();
            }
            else
            {
                hideAllPage4();
                showAllPage3();
            }
            
        }

        private void p4_home_Button4_Click(object sender, EventArgs e)
        {
            hideAllPage4();
            showAllPage1();
        }

        private void p4_currentPassword_textBox_TextChanged(object sender, EventArgs e)
        {
            p4_current = p4_currentPassword_textBox.Text;
        }

        private void p3_help_Button3_Click(object sender, EventArgs e)
        {
            hideAllPage3();
        }
    }
}
