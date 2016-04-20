function action=fuzzy_action_calculator(stat,input)
%% This function returns the next selected actions, this is fuzzy equivalent of action_selector
% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The code is released under the FreeBSD License.
% Copyright (C) 2016 Pooyan Jamshidi, Imperial College London
% The scripts implement Fuzzy Q-learning algorithm
% ------------------------------------------------------------------------


global NS FIS

% determine the number of antecedents of the rules in the knowledge base of
% the fuzzy logic controller
number_of_input=size(FIS.input,2);

% initialize the activation function or degree of truth of the rules in the
% knowledge base, again number of rules is equal to number of states in MDP
alpha=ones(NS,1);

% initialize vector that stores ai (action selected for each activated rul)
ais=zeros(NS,1);

% initialize output action to execute
action=0;

for i=1:NS % number of rules
    
    for j=1:number_of_input % number of antecedents
        
        % if the antecedent MF exists in the associated rule
        if FIS.rule(i).antecedent(j)>0
            %calculate the activation function
            alpha(i)=alpha(i)*evalmf(input(j),FIS.input(j).mf(FIS.rule(i).antecedent(j)).params,FIS.input(j).mf(FIS.rule(i).antecedent(j)).type);
        end
        
    end
    
   % select ai
    ais(i)=fuzzy_action_selector(stat,i);
    % calculate the action
    action=action+alpha(i)*FIS.output.mf(ais(i)).params;
    
end


