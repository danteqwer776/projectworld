using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f_game_30012017
{
    public partial class Form1 : Form
    {
        Static_obj[] all_ebjects=new Static_obj[0];//массив,содержащий елементы статической структуры--вода,трава
        Dinam_obj[] alife_obj = new Dinam_obj[0];//массив,содержащий елементы динам структуры--волк,корова

        Random M=new Random();

        public Form1()
        {
            InitializeComponent();
           
           

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button_create_Click(object sender, EventArgs e)
        {
            preparation_datagrid_map(dataGridView_map);
            buidling_static_world(dataGridView_map);
            

        }
        private void button_add_dinam_Click(object sender, EventArgs e)
        {
            building_dinam_world();
            refresh_world(dataGridView_map);
           

        }
        //наведение на groupbox
        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            refresh_obj_count_statistic(label_grs, label_wtr, label_cow, label_wf);
        }
        //__________________________________________________________________
        //__________________________________________________________________
        //_методы сценария

        public void preparation_datagrid_map(DataGridView dtgrdvw)//подготовка datagridview 
        {
            
            //находим макс число столбцов в строках
            int max_col = 10;
            for (int i = 0; i < 10; i++)
                if (20 > max_col)
                    max_col = 10;
            dtgrdvw.ColumnCount = 0;//очистка
            dtgrdvw.ColumnCount = max_col;//кол-во колонок
            dtgrdvw.Rows.Add(10);// кол-во строк 
                                                    //установки для столбцов
            for (int i = 0; i < max_col; i++)
            {
                //запрещаем менять значения ячеек
                dtgrdvw.Columns[i].ReadOnly = true;
                //отключение режима сортировки элементов столбца
                dtgrdvw.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                //заголовок столбцов
                //dtgrdvw.Columns[i].Name = i.ToString();
                dtgrdvw.Columns[i].Width = 25;//ширина столбцов
            }
            //отображение значений элементов матрицы в DataGridView
           /* for (int i = 0; i < 20; i++)
                for (int j = 0; j < 20; j++)
                    //заполнение ячейки 
                    dtgrdvw.Rows[i].Cells[j].Value = GR.Matrix_smeg[i][j].ToString();*/
            dtgrdvw.Visible = true;
            

        }

        public void buidling_static_world(DataGridView dtgrdvw)//генерация 'статич' обьектов и вывод их в datagridview
        {

            Array.Resize(ref all_ebjects,0);

            //working with collection of objects--filling collection
          
            int count;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    count = M.Next(-10, 3);
                    Array.Resize(ref all_ebjects, all_ebjects.Length + 1);
                    if(count>0) all_ebjects[all_ebjects.Length - 1] = new watter("blue");
                    else all_ebjects[all_ebjects.Length - 1] = new grass("green", M);

                    
                    all_ebjects[all_ebjects.Length - 1].x = i;//fill the filds-coordinates in object
                    all_ebjects[all_ebjects.Length - 1].y = j;

                }
               

            }

            //для построения карты стат элементов используется свой участок кода
             foreach(Static_obj obj in all_ebjects)
             {

            


                if (obj.color_in_map == "green")
                 {

                     dataGridView_map.Rows[obj.x].Cells[obj.y].Style.BackColor = System.Drawing.Color.Green;
                 }
                 if (obj.color_in_map == "blue")
                     dataGridView_map.Rows[obj.x].Cells[obj.y].Style.BackColor = System.Drawing.Color.Blue;
               
                 
                 //working with listbox--writting report
                if (obj.AnyDinamobject == true) dataGridView_map.Rows[obj.x].Cells[obj.y].Value = "1";
                else dataGridView_map.Rows[obj.x].Cells[obj.y].Value = "0";
            }


            //refresh_world(dtgrdvw);
            //working with listbox--writting report
            



        }

        public void building_dinam_world()//генерация 'динам' обьектов
        {
           
            Array.Resize(ref alife_obj,0);
            for (int i=0;i<all_ebjects.Length;i++)//перебор статич обьектов
            {
                
                if(all_ebjects[i].AnyDinamobject)//должен ли быть динам обьект
                {
                    
                    int help;
                  
                    help = M.Next(-4, 10);

                    Array.Resize(ref alife_obj, alife_obj.Length + 1);
                    if(help>0)
                    {
                        alife_obj[alife_obj.Length - 1] = new cow();//создаем 'динам' обьект
                        all_ebjects[i].seat_obj = alife_obj[alife_obj.Length - 1];//передаем ссылку динам обьекта статическому

                    }
                    else
                    {
                        alife_obj[alife_obj.Length - 1] = new wolf();
                        all_ebjects[i].seat_obj = alife_obj[alife_obj.Length - 1];


                    }
                  



                }



            }
            

        }
       
        //методы частого вызова
        //ВРЕМЕННЫЙ МЕТОД-ФУНКЦИЯ ПЕРЕЙДЕТ КЛАССУ STATISTIC
        public void refresh_world(DataGridView dtgrdvw)//обновляет изображение мира-datagridview
        {
            foreach(Static_obj obj in all_ebjects)
            {
                if(obj.AnyDinamobject)
                {
                    if (obj.seat_obj != null)
                    {
                        if (obj.seat_obj.color == "black")
                            dtgrdvw.Rows[obj.x].Cells[obj.y].Style.BackColor = System.Drawing.Color.Black;
                        if (obj.seat_obj.color == "white")
                            dtgrdvw.Rows[obj.x].Cells[obj.y].Style.BackColor = System.Drawing.Color.White;
                    }
                }
                else
                {
                    if (obj.color_in_map == "green")
                        dtgrdvw.Rows[obj.x].Cells[obj.y].Style.BackColor = System.Drawing.Color.Green;
                    if (obj.color_in_map == "blue")
                        dtgrdvw.Rows[obj.x].Cells[obj.y].Style.BackColor = System.Drawing.Color.Blue;
                }




            }



        }

        //ВРЕМЕННЫЙ МЕТОД-ФУНКЦИЯ ПЕРЕЙДЕТ КЛАССУ STATISTIC
        public void refresh_obj_count_statistic(Label lgrs,Label lwtr,Label lcw,Label lwlf)//обновляет информацию в полях groupbox'а о количестве обьектов
        {
            int s_cow = 0;
            int s_watter = 0;
            int s_grass = 0;
            int s_wlf = 0;

            Type tp,pt;

            foreach (Static_obj obj in all_ebjects)
            { tp = obj.GetType();

                    if (tp == typeof(grass)) s_grass++;
                    if (tp == typeof(watter)) s_watter++;
                if(obj.AnyDinamobject)
                {
                    pt = obj.seat_obj.GetType();

                    if (pt == typeof(wolf)) s_wlf++;
                    if (pt == typeof(cow)) s_cow++;

                }


            }
                lcw.Text = (s_cow).ToString();
                lwlf.Text = (s_wlf).ToString();
                lgrs.Text = (s_grass).ToString();
                lwtr.Text = (s_watter).ToString();

            s_cow = 0;
            s_watter = 0;
            s_grass = 0;
            s_wlf = 0;
        }



      
    }

  
}
